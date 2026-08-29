//################################################################################
//FileName: peTest.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 24/8/2021 12:00:00 PM
//Last Modified On : 12/11/2025 08:20:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
//  ------------------------------------------------------------------------------
//v2.0.11.25                                                           12 Nov 2025
//  - Update aboutPE add Dept name
//  - Add Dept name and version in PE_Form
//  - Adjust size of dmmValue to can be received 4.3 digits
//  - Add DMM reset button to Main page
//  - Add command dmm reset at clear button event occured
//  - Add excel kill process before program open excel to load configuration
//  - Re-arrange enable GUI process when start program/confirm select program
//  - Add blacklist to block user access program
//  - Change open spec each project to be modeless form
//  - show aboutPE at program start to be welcome form
//  - Adjust sampling time of dangerTime from 650mS to 1000mS
//  - Change .net framework from 4.0 to 4.5 for Threading.task support
//################################################################################
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Globalization;

namespace PE
{
    public partial class peTest : Form
    {
        private const string PesatRootPath = @"D:\Automotive_Software_DET5\PESAT";
        private const string ConfigPath = PesatRootPath + @"\database\config.ini";
        private const string DatabasePath = PesatRootPath + @"\database\pe_database.xlsx";
        private const string ReportRootPath = @"D:\PE_DATA";

        private IniFile ini = new IniFile(ConfigPath);
        private readonly StringBuilder dcReceiveBuffer = new StringBuilder();
        private readonly StringBuilder dmmReceiveBuffer = new StringBuilder();
        private readonly object dcReceiveLock = new object();
        private readonly object dmmReceiveLock = new object();
        private bool isClosing;
        private bool suppressDcStatusHandling;
        private bool hasValidMeasurement;
        private DateTime lastMeasurementAtUtc = DateTime.MinValue;
        private _Application app;
        private _Workbook workBook;
        private _Worksheet workSheet;
        private Range range;
        private string projSheet;
        private string trimSN;
        private int cntRow = 0;
        private decimal resMax = 0;
        private decimal measValue;
        private decimal voltValue = 0;
        private decimal resValue = 0;
        private decimal currValue = 0;
        private string resultValue;

        private List<string> BlackList = new List<string>();
        private List<string> file_List = new List<string>();

        public peTest()
        {
            InitializeComponent();
            dangerTime.Stop();
            toolStripStatusLabel.Text = "Device not connected";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            addBlackList("delta\\Larry");
            addBlackList("delta\\sutsoboo");
            checkBlackList();

            toolStripStatusLabel.Text = "Device not connected";
            lblDCPort.Text = null;
            lblDMMPort.Text = null;
            dangerTime.Stop();

            await Task.Delay(1);
            aboutPE startFrm = new aboutPE();
            startFrm.Show();
            await Task.Delay(1000);
            startFrm.Close();
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosing)
            {
                return;
            }

            e.Cancel = true;
            isClosing = true;
            await SafeStopOutputAsync();

            comPort1.DataReceived -= port_DataReceived_1;
            comPort2.DataReceived -= port_DataReceived_2;
            CloseSerialPorts();

            // Cancel this close request and issue a new one after the asynchronous safety work.
            BeginInvoke(new System.Action(Close));
        }

        private void addBlackList(string User)
        {
            BlackList.Add(User.ToLower());
        }

        private void checkBlackList()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Console.WriteLine(userName);
            if (BlackList.Contains(userName.ToLower()))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "An internal error occured while installing the service pack." + Environment.NewLine + Environment.NewLine + "Error code: 0x80070002."
                    + Environment.NewLine + Environment.NewLine + "See " + "http://go.microsoft.com/fwlink/?LinkId=101139 for details."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /*====================================================================================================*/
        /*--------------------------------------------SerialPort----------------------------------------------*/

        //NOT USE---------------------------------------------------------------------------------------------
        private void btnScan_Click(object sender, EventArgs e)
        {
            int index = -1;
            cbbPort.Items.Clear();
            cbbBaud.Items.Clear();
            btnState.Enabled = true;
            //Com Ports
            try
            {
                string[] ArrayComPortsNames = SerialPort.GetPortNames();
                do
                {
                    index += 1;
                    cbbPort.Items.Add(ArrayComPortsNames[index]);
                } while (!((ArrayComPortsNames[index] == null) || (index == ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
                //get first item print in text
                cbbPort.Text = ArrayComPortsNames[0];
                //Baud Rate
                cbbBaud.Items.Add(9600);
                cbbBaud.Items.Add(14400);
                cbbBaud.Items.Add(19200);
                cbbBaud.Items.Add(38400);
                cbbBaud.Items.Add(57600);
                cbbBaud.Items.Add(115200);
                cbbBaud.Text = cbbBaud.Items[0].ToString();
            }
            catch
            {
                MessageBox.Show("Port Unavailable. Please check on Device Manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (btnState.Text == "Connect")
            {
                btnState.Text = "Disconnect";
                comPort1.PortName = Convert.ToString(cbbPort.Text);
                comPort1.BaudRate = Convert.ToInt32(cbbBaud.Text);
                comPort1.Open();
                btnScan.Enabled = false;
                cbbPort.Enabled = false;
                cbbBaud.Enabled = false;
                connect.Visible = true;
                disConnect.Visible = false;
                comPort1.RtsEnable = true;
                comPort1.DtrEnable = true;
                statusBox.BackColor = Color.LawnGreen;
                notifySerial.Icon = SystemIcons.Application;
                notifySerial.BalloonTipText = cbbPort.Text + "  has been Connected";
                notifySerial.ShowBalloonTip(1000);
                toolStripStatusLabel.Text = "Ready";
            }
            else if (btnState.Text == "Disconnect")
            {
                btnState.Text = "Connect";
                comPort1.RtsEnable = false;
                comPort1.DtrEnable = false;
                comPort1.Close();
                btnScan.Enabled = true;
                cbbPort.Enabled = true;
                cbbBaud.Enabled = true;
                connect.Visible = false;
                disConnect.Visible = true;
                toolStripStatusLabel.Text = "Device not connected";
                rtbIncoming1.Clear();
                statusBox.BackColor = Color.Red;
                notifySerial.Icon = SystemIcons.Application;
                notifySerial.BalloonTipText = cbbPort.Text + "  has been Disconnected";
                notifySerial.ShowBalloonTip(1000);
            }
        }

        /*====================================================================================================*/
        /*-------------------------------------------Read Port1-----------------------------------------------*/

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            if (isClosing)
            {
                return;
            }

            try
            {
                string inputData = comPort1.ReadExisting();
                foreach (string message in ExtractCompleteMessages(dcReceiveBuffer, dcReceiveLock, inputData))
                {
                    if (!suppressDcStatusHandling && IsHandleCreated && !IsDisposed)
                    {
                        BeginInvoke(new System.Action<string>(SetText1), message);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Read DC serial port", ex);
            }
        }

        private void SetText1(string message)
        {
            rtbIncoming1.Text = message;

            if (message == "1")
            {
                rtbIncoming2.Clear();
                hasValidMeasurement = false;
                Text = "PE TESTING (RUNNING)";
                testProgram.Enabled = false;
                setPoint.Enabled = false;
                manualTool.Enabled = false;
                pushStart.Text = "Push foot button to Stop ...";
                pushStart.ForeColor = Color.Red;
                dangerTime.Start();
                toolStripStatusLabel.Text = "Testing...";
                return;
            }

            if (message != "0")
            {
                return;
            }

            Text = "PE TESTING";
            testProgram.Enabled = true;
            setPoint.Enabled = true;
            manualTool.Enabled = true;
            fileSaveAs.Enabled = true;
            exportTool.Enabled = true;
            pushStart.Visible = true;
            dangerOn.Visible = false;
            pushStart.Text = "Push foot button to Start ...";
            pushStart.ForeColor = Color.RoyalBlue;
            dangerTime.Stop();
            toolStripStatusLabel.Text = "Ready";
            CompleteCurrentTestStep();
        }

        private void CompleteCurrentTestStep()
        {
            if (cntRow < 0 || cntRow >= gridTable1.Rows.Count)
            {
                MessageBox.Show("Testing Done.", "PE TESTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow currentRow = gridTable1.Rows[cntRow];
            if (currentRow.IsNewRow || currentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Testing Done.", "PE TESTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!hasValidMeasurement || DateTime.UtcNow - lastMeasurementAtUtc > TimeSpan.FromSeconds(5))
            {
                MessageBox.Show("No fresh DMM measurement is available. Please check the DMM connection and repeat this test point.",
                    "Measurement unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currValue <= 0)
            {
                MessageBox.Show("Current setpoint must be greater than zero before resistance can be calculated.",
                    "Invalid current setpoint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryConvertToDecimal(currentRow.Cells[1].Value, out resMax))
            {
                MessageBox.Show("The maximum resistance value in the selected test program is invalid.",
                    "Invalid test limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            voltValue = measValue;
            resValue = voltValue / currValue;
            currentRow.Cells[2].Value = measValue;
            currentRow.Cells[3].Value = resValue;

            bool passed = resValue <= resMax;
            resultValue = passed ? "PASS" : "FAIL";
            currentRow.Cells[4].Value = resultValue;
            currentRow.Cells[4].Style.ForeColor = passed ? Color.Green : Color.Red;

            cntRow++;
            hasValidMeasurement = false;

            if (cntRow >= gridTable1.Rows.Count ||
                gridTable1.Rows[cntRow].IsNewRow ||
                gridTable1.Rows[cntRow].Cells[0].Value == null)
            {
                MessageBox.Show("Testing Done.", "PE TESTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Clear Lastest data in gridTable1
        private void btnClearData_Click(object sender, EventArgs e)
        {
            if (cntRow <= 0)
            {
                MessageBox.Show("Data unavailable to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cntRow--;
            gridTable1.Rows[cntRow].Cells[2].Value = null;
            gridTable1.Rows[cntRow].Cells[3].Value = null;
            gridTable1.Rows[cntRow].Cells[4].Value = null;
            hasValidMeasurement = false;

            try
            {
                if (comPort2.IsOpen)
                {
                    comPort2.Write("*cls\r\n");
                }
            }
            catch (Exception ex)
            {
                LogError("Clear DMM status", ex);
            }
        }

        /*-------------------------------------------Read Port2-----------------------------------------------*/

        private void port_DataReceived_2(object sender, SerialDataReceivedEventArgs e)
        {
            if (isClosing)
            {
                return;
            }

            try
            {
                string inputData = comPort2.ReadExisting();
                foreach (string message in ExtractCompleteMessages(dmmReceiveBuffer, dmmReceiveLock, inputData))
                {
                    if (IsHandleCreated && !IsDisposed)
                    {
                        BeginInvoke(new System.Action<string>(SetText2), message);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Read DMM serial port", ex);
            }
        }

        private void SetText2(string message)
        {
            rtbIncoming2.Text = message;

            decimal decimalValue;
            if (!Decimal.TryParse(message.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out decimalValue))
            {
                LogError("Parse DMM measurement", new FormatException("Unsupported DMM response: " + message));
                return;
            }

            decimal milliValue = Math.Abs(decimalValue * 1000M);
            string finalValue = milliValue.ToString("0.000", CultureInfo.InvariantCulture);

            value.Text = finalValue;
            valueDMM.Text = finalValue;
            measValue = milliValue;
            lastMeasurementAtUtc = DateTime.UtcNow;
            hasValidMeasurement = true;
        }

        private static List<string> ExtractCompleteMessages(StringBuilder receiveBuffer, object receiveLock, string inputData)
        {
            List<string> messages = new List<string>();
            if (String.IsNullOrEmpty(inputData))
            {
                return messages;
            }

            lock (receiveLock)
            {
                receiveBuffer.Append(inputData);
                string bufferedText = receiveBuffer.ToString();
                int lineEndIndex;

                while ((lineEndIndex = bufferedText.IndexOf('\n')) >= 0)
                {
                    string message = bufferedText.Substring(0, lineEndIndex).TrimEnd('\r');
                    bufferedText = bufferedText.Substring(lineEndIndex + 1);

                    if (!String.IsNullOrWhiteSpace(message))
                    {
                        messages.Add(message);
                    }
                }

                receiveBuffer.Clear();
                receiveBuffer.Append(bufferedText);
            }

            return messages;
        }

        private static bool TryConvertToDecimal(object valueToConvert, out decimal convertedValue)
        {
            try
            {
                convertedValue = Convert.ToDecimal(valueToConvert, CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                convertedValue = 0;
                return false;
            }
        }

        /*====================================================================================================*/
        /*------------------------------------------Select Program--------------------------------------------*/

        //Auto insert program
        private void programList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            projSheet = programList.Text;
        }

        private async void confirmSelectBtn_Click(object sender, EventArgs e)
        {
            gridTable1.Rows.Clear();
            confirmSelectBtn.Enabled = false;
            setPoint.Enabled = false;
            programList.Enabled = false;
            tbSn.Enabled = false;

            try
            {
                projSheet = programList.Text;
                if (String.IsNullOrWhiteSpace(projSheet))
                {
                    throw new InvalidOperationException("Please select a test program.");
                }

                if (!comPort1.IsOpen)
                {
                    throw new InvalidOperationException("The DC source communication port is not connected.");
                }

                CloseExcelResources();
                app = new Microsoft.Office.Interop.Excel.Application();
                workBook = app.Workbooks.Open(DatabasePath);
                workSheet = workBook.Worksheets[projSheet];
                range = workSheet.UsedRange;

                for (int excelRowIndex = 2; excelRowIndex < range.Rows.Count + 1; excelRowIndex++)
                {
                    gridTable1.Rows.Add(workSheet.Cells[excelRowIndex, 1].Value, workSheet.Cells[excelRowIndex, 2].Value);
                }

                double dbSetVolt = Convert.ToDouble(workSheet.Cells[2, 3].Value, CultureInfo.InvariantCulture);
                double dbSetCurr = Convert.ToDouble(workSheet.Cells[2, 4].Value, CultureInfo.InvariantCulture);

                comPort1.Write("v," + dbSetVolt.ToString(CultureInfo.InvariantCulture) + "\r\n");
                await Task.Delay(2000);
                comPort1.Write("a," + dbSetCurr.ToString(CultureInfo.InvariantCulture) + "\r\n");
                await Task.Delay(1000);
                comPort1.Write("*cls\r\n");

                voltBox.Value = Convert.ToInt32(dbSetVolt);
                currBox.Value = Convert.ToInt32(dbSetCurr);
                currValue = currBox.Value;
                cntRow = 0;
                hasValidMeasurement = false;

                TryUpdateReportSerialNumber(false);
                if (!String.IsNullOrWhiteSpace(tbSn.Text) && !tbSn.AutoCompleteCustomSource.Contains(tbSn.Text))
                {
                    tbSn.AutoCompleteCustomSource.Add(tbSn.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load test program", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError("Load selected test program", ex);
            }
            finally
            {
                CloseExcelResources();
                confirmSelectBtn.Enabled = true;
                setPoint.Enabled = true;
                programList.Enabled = true;
                tbSn.Enabled = true;
            }
        }

        //Manual insert program
        private void insertBtn_Click(object sender, EventArgs e)
        {
            /*//Add new program in programList
            string message, title;
            object newProgram;

            message = "Please input new test program name.";
            title = "New program insert.";
            newProgram = Interaction.InputBox(message, title, default);

            if ((string)newProgram != "")
            {
                programList.Items.Insert(0, newProgram);
            }*/

            gridTable1.Rows.Clear();
            foreach (DataGridViewRow row in gridTable2.Rows)
            {
                gridTable1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
            }

            //Back to Home
            testProgram.Visible = true;
            setPoint.Visible = true;
            startTesting.Visible = true;
            getData.Visible = true;
            testData.Visible = true;
            editSpecTest.Visible = false;
            serialPort.Visible = false;
            programList.SelectedIndex = 0;

            //Enable test
            setPoint.Enabled = true;
            startTesting.Enabled = true;
            getData.Enabled = true;
        }

        private void delProgBtn_Click(object sender, EventArgs e)
        {
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            gridTable2.Rows.Clear();
        }

        /*====================================================================================================*/
        /*--------------------------------------------DC Source-----------------------------------------------*/

        //Auto DC source --------------------------------------------------------------------------------------
        //Delete value in box when click
        private void voltBox_MouseClick(object sender, MouseEventArgs e)
        {
            voltBox.ResetText();
        }

        private void currBox_MouseClick(object sender, MouseEventArgs e)
        {
            currBox.ResetText();
        }

        //Button Click to set
        private void btnSetVolt_Click(object sender, EventArgs e)
        {
            pushStart.Visible = true;
            comPort1.Write("v," + voltBox.Value + "\r\n");
        }

        private void btnSetCurr_Click(object sender, EventArgs e)
        {
            pushStart.Visible = true;
            currValue = currBox.Value;
            comPort1.Write("a," + currBox.Value + "\r\n");
        }

        //Enter to set
        private void voltBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pushStart.Visible = true;
                comPort1.Write("v," + voltBox.Value + "\r\n");
            }
        }

        private void currBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                currValue = currBox.Value;
                comPort1.Write("a," + currBox.Value + "\r\n");
            }
        }

        //Manual DC source-------------------------------------------------------------------------------------
        //Command DC
        private void btnRemoteDC_Click(object sender, EventArgs e)
        {
            try
            {
                tbIdentDC.Text = "CHROMA ATE,62100H-40,00118,02.21";        //Manual
                /*comPort1.Write("*idn?\r\n");
                System.Threading.Thread.Sleep(2000);    //Delay command 2 sec*/
                comPort1.Write("conf:rem\r\n");
            }
            catch
            {
                tbIdentDC.Text = "Error.";
            }
        }

        private void btnClearDC_Click(object sender, EventArgs e)
        {
            try
            {
                comPort1.Write("*cls\r\n");
            }
            catch
            {
                tbIdentDC.Text = "Error.";
            }
        }

        private void tbCommandDC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    comPort1.Write(tbCommandDC.Text + "\r\n");
                }
            }
            catch
            {
                tbIdentDC.Text = "Error.";
            }
        }

        //Setpoint DC
        //Button Click to set
        private void btnSetVoltManual_Click(object sender, EventArgs e)
        {
            comPort1.Write("v," + voltBoxManual.Value + "\r\n");
        }

        private void btnSetCurrManual_Click(object sender, EventArgs e)
        {
            comPort1.Write("a," + currBoxManual.Value + "\r\n");
        }

        //Enter to set
        private void voltBoxManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comPort1.Write("v," + voltBoxManual.Value + "\r\n");
            }
        }

        private void currBoxManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comPort1.Write("a," + currBoxManual.Value + "\r\n");
            }
        }

        private void btnToggleOff_Click(object sender, EventArgs e)
        {
            this.Text = "PE TESTING (OUTPUT ON)";
            btnToggleOff.Visible = false;
            btnToggleOn.Visible = true;
            lblToggleOff.Visible = false;
            lblToggleOn.Visible = true;

            comPort1.Write("1");
        }

        private void btnToggleOn_Click(object sender, EventArgs e)
        {
            this.Text = "PE TESTING";
            btnToggleOn.Visible = false;
            btnToggleOff.Visible = true;
            lblToggleOn.Visible = false;
            lblToggleOff.Visible = true;

            comPort1.Write("0");
        }

        //Cal date
        private void btnCalDC_Click(object sender, EventArgs e)
        {
            using (calDC calibrationDialog = new calDC())
            {
                calibrationDialog.ShowDialog(this);
                Properties.Settings.Default.dcCalDate = calibrationDialog.mtbCalDate.Text;
                Properties.Settings.Default.dcDueDate = calibrationDialog.mtbDueDate.Text;
                Properties.Settings.Default.Save();
            }
        }

        /*--------------------------------------------Multimeter-------------------------------------------*/

        //Manual DMM --------------------------------------------------------------------------------------
        private void btnRemoteDMM_Click(object sender, EventArgs e)
        {
            try
            {
                //comPort2.Write("*idn?\r\n");
                tbIdentDMM.Text = "HEWLETT-PACKARD,34401A,0,11-5-3";        //Manual
                comPort2.Write("syst:rem\r\n");
            }
            catch
            {
                tbIdentDMM.Text = "Error.";
            }
        }

        private void btnClearDMM_Click(object sender, EventArgs e)
        {
            try
            {
                comPort2.Write("*cls\r\n");
            }
            catch
            {
                tbIdentDMM.Text = "Error.";
            }
        }

        private void tbCommandDMM_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    comPort2.Write(tbCommandDMM.Text + "\r\n");
                }
            }
            catch
            {
                tbIdentDMM.Text = "Error.";
            }
        }

        private void btnStartMeasure_Click(object sender, EventArgs e)
        {
            btnStartMeasure.Enabled = false;
            btnStopMeasure.Enabled = true;
            dangerTime.Start();
            this.Text = "PE TESTING (Measuring)";
        }

        private void btnStopMeasure_Click(object sender, EventArgs e)
        {
            btnStartMeasure.Enabled = true;
            btnStopMeasure.Enabled = false;
            dangerTime.Stop();
            this.Text = "PE TESTING";
            valueDMM.Text = "----.---";
            pushStart.Visible = false;
            dangerOn.Visible = false;
        }

        //Cal date
        private void btnCalDMM_Click(object sender, EventArgs e)
        {
            using (calDMM calibrationDialog = new calDMM())
            {
                calibrationDialog.ShowDialog(this);
                Properties.Settings.Default.dmmCalDate = calibrationDialog.mtbCalDate.Text;
                Properties.Settings.Default.dmmDueDate = calibrationDialog.mtbDueDate.Text;
                Properties.Settings.Default.Save();
            }
        }

        /*====================================================================================================*/
        /*-----------------------------------------DangerSign/Run---------------------------------------------*/

        private void dangerTime_Tick(object sender, EventArgs e)
        {
            if (!comPort2.IsOpen)
            {
                dangerTime.Stop();
                toolStripStatusLabel.Text = "DMM disconnected";
                return;
            }

            try
            {
                comPort2.Write("meas:volt:dc?\r\n");
            }
            catch (Exception ex)
            {
                dangerTime.Stop();
                toolStripStatusLabel.Text = "DMM communication error";
                LogError("Request DMM measurement", ex);
            }

            dangerOn.Visible = !dangerOn.Visible;
            pushStart.Visible = !pushStart.Visible;
        }

        /*====================================================================================================*/
        /*----------------------------------------------Interface---------------------------------------------*/

        //File Open Menu
        private void fileOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                Process.Start(openFile.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError("Open selected file", ex);
            }
        }

        //File Save Menu
        private void fileSave_Click(object sender, EventArgs e)
        {
        }

        //File Save As Menu
        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            ExportReportWithDialog();
        }

        //File exit Menu
        private void fileExit_Click(object sender, EventArgs e)
        {
            if (confirmDialog.Show("Do you want to exit ?", "PE TESTING") == DialogResult.Yes)
            {
                Close();
            }
        }

        //Config port Menu
        private void configPort_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigPath);
        }

        //Config edit Menu
        private void configEdit_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            startTesting.Visible = false;
            getData.Visible = false;
            testData.Visible = false;
            editSpecTest.Visible = true;
            editSpecTest.Height = 450;
            editSpecTest.Location = new System.Drawing.Point(12, 11);
            serialPort.Visible = false;
            manualDC.Visible = false;
        }

        //Config Manual
        private void configManual_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            startTesting.Visible = false;
            getData.Visible = false;
            testData.Visible = false;
            editSpecTest.Visible = false;
            serialPort.Visible = false;
            manualDC.Visible = true;
            manualDC.Location = new System.Drawing.Point(12, 11);
            manualDC.Size = new System.Drawing.Size(876, 600);
        }

        //Config Database
        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDatabaseFile();
        }

        //Help >>> Spec
        private void helpSpecBMW_Click(object sender, EventArgs e)
        {
            specBMW bmwSpec = new specBMW();
            bmwSpec.Text = "BMW Specification";
            bmwSpec.Show();
        }

        private void helpSpecOBC_Click(object sender, EventArgs e)
        {
            specOBC obcSpec = new specOBC();
            obcSpec.Text = "DAIMLER-OBC Specification";
            obcSpec.Show();
        }

        private void helpSpecDCB_Click(object sender, EventArgs e)
        {
            specDCB dcbSpec = new specDCB();
            dcbSpec.Text = "DAIMLER-DC Box Specificationn";
            dcbSpec.Show();
        }

        private void helpSpecREN_Click(object sender, EventArgs e)
        {
            specREN renSpec = new specREN();
            renSpec.Text = "Renault 5DH Specification";
            renSpec.Show();
        }

        private void helpSpecNIS_Click(object sender, EventArgs e)
        {
            specNIS nisSpec = new specNIS();
            nisSpec.Text = "Nissan OBC Specification";
            nisSpec.Show();
        }

        //Help >>> Equipment manual
        private void helpEqManDC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\PESAT\manual\62000h_series.pdf");
        }

        private void helpEqManDMM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\PESAT\manual\34460a-34461a-34465a-34470a_manual.pdf");
        }

        //Help >>> PE Testing manual
        private void helpPEMan_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\PESAT\manual\PESAT_manual.pdf");
            }
            catch
            {
                MessageBox.Show("Under preparing process.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Help >>> Info
        private void helpInfo_Click(object sender, EventArgs e)
        {
            aboutPE.Show("About PE semi-auto testing");
        }

        //Tool Strip
        //Start button
        private async void startTool_Click(object sender, EventArgs e)
        {
            String _port1 = ini.IniReadValue("DC-SOURCE", "PORT");
            String _baud1 = ini.IniReadValue("DC-SOURCE", "BAUDRATE");
            String _port2 = ini.IniReadValue("DMM", "PORT");
            String _baud2 = ini.IniReadValue("DMM", "BAUDRATE");
            lblDCPort.Text = comPort1.PortName + "," + comPort1.BaudRate;
            lblDCPort.BackColor = Color.Red;
            lblDMMPort.Text = comPort2.PortName + "," + comPort2.BaudRate;
            lblDMMPort.BackColor = Color.Red;

            if (startTool.Text == "Stop")
            {
                cntRow = 0;
                startTool.Image = new Bitmap(PE.Properties.Resources.icons8_conflict_48);
                startTool.Text = "Start";
                startTool.ToolTipText = "Click to start program.";

                await SafeStopOutputAsync();
                CloseSerialPorts();

                toolStripStatusLabel.Text = "Device not connected";
                rtbIncoming1.Clear();

                //GUI Manager
                connect.Visible = false;
                disConnect.Visible = true;
                fileSave.Enabled = false;
                fileSaveAs.Enabled = false;
                manualTool.Enabled = true;
                databaseTool.Enabled = true;
                exportTool.Enabled = false;
                testProgram.Enabled = false;
                setPoint.Enabled = false;
                startTesting.Enabled = false;
                pushStart.Visible = true;
                dangerOn.Visible = false;
                pushStart.Text = "Push foot button to Start ...";
                pushStart.ForeColor = Color.RoyalBlue;
                dangerTime.Stop();
                getData.Enabled = false;
                testData.Enabled = false;
                manualDC.Enabled = false;
                editSpecTest.Enabled = false;

                //Auto export after the equipment has been moved to a safe state.
                if (TryUpdateReportSerialNumber(true))
                {
                    Directory.CreateDirectory(ReportRootPath);
                    string automaticReportPath = Path.Combine(ReportRootPath, BuildReportFileName());
                    ExportReport(automaticReportPath, false);
                }
            }
            else if (startTool.Text == "Start")
            {
                startTool.Image = new Bitmap(PE.Properties.Resources.icons8_full_stop_48);
                startTool.Text = "Stop";
                startTool.ToolTipText = "Click to stop program and export data.";

                //Port1-DC
                try
                {
                    comPort1.PortName = _port1;
                    comPort1.BaudRate = int.Parse(_baud1);
                    comPort1.Open();
                    comPort1.RtsEnable = true;
                    comPort1.DtrEnable = true;
                    lblDCPort.Text = comPort1.PortName + "," + comPort1.BaudRate;
                    lblDCPort.BackColor = Color.LawnGreen;

                    //GUI Enable
                    editSpecTest.Enabled = true;
                    //manualTool.Enabled = true;
                    databaseTool.Enabled = false;
                    manualDC.Enabled = true;

                    //Inintial DC
                    comPort1.Write("*cls\r\n");
                    await Task.Delay(2000);
                    comPort1.Write("conf:rem\r\n");
                }
                catch
                {
                    setPoint.Enabled = false;
                    startTesting.Enabled = false;
                    manualDC.Enabled = false;
                    lblDCPort.Text = comPort1.PortName + "," + comPort1.BaudRate;
                    lblDCPort.BackColor = Color.Red;
                }

                //Port2-DMM
                try
                {
                    comPort2.PortName = _port2;
                    comPort2.BaudRate = int.Parse(_baud2);
                    comPort2.Open();
                    comPort2.RtsEnable = true;
                    comPort2.DtrEnable = true;
                    lblDMMPort.Text = comPort2.PortName + "," + comPort2.BaudRate;
                    lblDMMPort.BackColor = Color.LawnGreen;

                    //GUI Enable
                    editSpecTest.Enabled = true;
                    databaseTool.Enabled = false;

                    //Inintial DMM
                    comPort2.Write("*cls\r\n");
                    await Task.Delay(1000);
                    comPort2.Write("syst:rem\r\n");
                }
                catch
                {
                    getData.Enabled = false;
                    testData.Enabled = false;
                    lblDMMPort.Text = comPort2.PortName + "," + comPort2.BaudRate;
                    lblDMMPort.BackColor = Color.Red;
                }

                //Pull test programs from the database workbook.
                try
                {
                    CloseExcelResources();
                    programList.Items.Clear();
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(DatabasePath);

                    foreach (Worksheet sheet in workBook.Worksheets)
                    {
                        try
                        {
                            programList.Items.Add(sheet.Name);
                        }
                        finally
                        {
                            Marshal.FinalReleaseComObject(sheet);
                        }
                    }

                    if (programList.Items.Count == 0)
                    {
                        throw new InvalidOperationException("The database does not contain any test program.");
                    }

                    programList.SelectedIndex = 0;
                    projSheet = programList.Text;

                    testData.Enabled = true;
                    getData.Enabled = true;
                    setPoint.Enabled = true;
                    startTesting.Enabled = true;
                    testProgram.Enabled = true;
                    connect.Visible = true;
                    disConnect.Visible = false;
                    toolStripStatusLabel.Text = "Ready";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Program can't list the test sequence in the database. Please check the database file.\r\n\r\n" + ex.Message,
                        "PE TESTING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    LogError("List test programs", ex);
                }
                finally
                {
                    CloseExcelResources();
                }
            }
        }

        //Home button
        private void homeTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = true;
            setPoint.Visible = true;
            startTesting.Visible = true;
            getData.Visible = true;
            value.Text = "----.---";
            testData.Visible = true;
            editSpecTest.Visible = false;
            serialPort.Visible = false;
            manualDC.Visible = false;
        }

        //Edit button
        private void editTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            startTesting.Visible = false;
            getData.Visible = false;
            testData.Visible = false;
            editSpecTest.Visible = true;
            editSpecTest.Height = 450;
            editSpecTest.Location = new System.Drawing.Point(12, 11);
            serialPort.Visible = false;
            manualDC.Visible = false;
        }

        //Database button
        private void databaseTool_Click(object sender, EventArgs e)
        {
            OpenDatabaseFile();
        }

        //Manual button
        private void manualTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            startTesting.Visible = false;
            getData.Visible = false;
            testData.Visible = false;
            editSpecTest.Visible = false;
            serialPort.Visible = false;
            manualDC.Visible = true;
            manualDC.Location = new System.Drawing.Point(12, 11);
            manualDC.Size = new System.Drawing.Size(876, 600);
        }

        //Export button
        private void exportTool_Click(object sender, EventArgs e)
        {
            ExportReportWithDialog();
        }

        //Shutdown button
        private void shutdownTool_Click(object sender, EventArgs e)
        {
            if (confirmDialog.Show("Do you want to exit ?", "PE TESTING") == DialogResult.Yes)
            {
                Close();
            }
        }

        /*====================================================================================================*/
        /*-----------------------------------------Safety helpers---------------------------------------------*/

        private async Task SafeStopOutputAsync()
        {
            bool previousSuppressState = suppressDcStatusHandling;
            suppressDcStatusHandling = true;
            dangerTime.Stop();

            try
            {
                if (comPort1.IsOpen)
                {
                    comPort1.Write("0");
                    await Task.Delay(1200);
                }
            }
            catch (Exception ex)
            {
                LogError("Turn DC output off during shutdown", ex);
            }
            finally
            {
                suppressDcStatusHandling = previousSuppressState;
            }
        }

        private void CloseSerialPorts()
        {
            CloseSerialPort(comPort1, "DC source");
            CloseSerialPort(comPort2, "DMM");
        }

        private static void CloseSerialPort(SerialPort serialPort, string deviceName)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    return;
                }

                serialPort.RtsEnable = false;
                serialPort.DtrEnable = false;
                serialPort.Close();
            }
            catch (Exception ex)
            {
                LogError("Close " + deviceName + " serial port", ex);
            }
        }

        private bool TryUpdateReportSerialNumber(bool showMessage)
        {
            string serialNumber = (tbSn.Text ?? String.Empty).Trim();
            if (serialNumber.Length == 0)
            {
                if (showMessage)
                {
                    MessageBox.Show("Please enter the DUT serial number before exporting the report.",
                        "Serial number required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                trimSN = String.Empty;
                return false;
            }

            string serialSuffix = serialNumber.Length <= 6
                ? serialNumber
                : serialNumber.Substring(serialNumber.Length - 6);

            foreach (char invalidCharacter in Path.GetInvalidFileNameChars())
            {
                serialSuffix = serialSuffix.Replace(invalidCharacter, '_');
            }

            trimSN = serialSuffix;
            return true;
        }

        private void ExportReportWithDialog()
        {
            if (!TryUpdateReportSerialNumber(true))
            {
                return;
            }

            saveData.DefaultExt = "xlsx";
            saveData.AddExtension = true;
            saveData.FileName = BuildReportFileName();

            if (saveData.ShowDialog() == DialogResult.OK)
            {
                ExportReport(saveData.FileName, true);
            }
        }

        private string BuildReportFileName()
        {
            return "PE_SN" + trimSN + "_" +
                DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss", CultureInfo.InvariantCulture) +
                ".xlsx";
        }

        private bool ExportReport(string reportPath, bool showSuccessMessage)
        {
            if (!TryUpdateReportSerialNumber(true))
            {
                return false;
            }

            try
            {
                string reportDirectory = Path.GetDirectoryName(reportPath);
                if (!String.IsNullOrEmpty(reportDirectory))
                {
                    Directory.CreateDirectory(reportDirectory);
                }

                CloseExcelResources();
                app = new Microsoft.Office.Interop.Excel.Application();
                workBook = app.Workbooks.Add(1);
                workSheet = workBook.ActiveSheet;

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss", CultureInfo.InvariantCulture);
                workSheet.Name = "PE_SN" + trimSN + "_" + timestamp;
                workSheet.Cells[1, 1] = "Project";
                workSheet.Cells[1, 2] = programList.Text;
                workSheet.Cells[2, 1] = "Serial No.";
                workSheet.Cells[2, 2] = "'" + tbSn.Text.Trim();
                workSheet.Cells[3, 1] = "Test Date";
                workSheet.Cells[3, 2] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
                workSheet.Cells[4, 1] = "DC Cal.Date";
                workSheet.Cells[4, 2] = Properties.Settings.Default.dcCalDate;
                workSheet.Cells[5, 1] = "DMM Cal.Date";
                workSheet.Cells[5, 2] = Properties.Settings.Default.dmmCalDate;

                for (int columnIndex = 0; columnIndex < gridTable1.Columns.Count; columnIndex++)
                {
                    workSheet.Cells[6, columnIndex + 1] = gridTable1.Columns[columnIndex].HeaderText;
                }

                int excelRow = 7;
                foreach (DataGridViewRow dataRow in gridTable1.Rows)
                {
                    if (dataRow.IsNewRow)
                    {
                        continue;
                    }

                    for (int columnIndex = 0; columnIndex < gridTable1.Columns.Count; columnIndex++)
                    {
                        workSheet.Cells[excelRow, columnIndex + 1] = dataRow.Cells[columnIndex].Value;
                    }

                    excelRow++;
                }

                range = workSheet.UsedRange;
                range.Columns.AutoFit();
                workBook.SaveAs(reportPath);

                if (showSuccessMessage)
                {
                    MessageBox.Show(
                        "Report generated successfully.",
                        "PE TESTING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                fileSave.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to export the report.\r\n\r\n" + ex.Message,
                    "PE TESTING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LogError("Export report", ex);
                return false;
            }
            finally
            {
                CloseExcelResources();
            }
        }

        private void OpenDatabaseFile()
        {
            try
            {
                if (!File.Exists(DatabasePath))
                {
                    throw new FileNotFoundException("Database file was not found.", DatabasePath);
                }

                Process.Start(DatabasePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open the database.\r\n\r\n" + ex.Message,
                    "PE TESTING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LogError("Open database", ex);
            }
        }

        private void CloseExcelResources()
        {
            try
            {
                if (workBook != null)
                {
                    workBook.Close(false);
                }
            }
            catch (Exception ex)
            {
                LogError("Close Excel workbook", ex);
            }

            try
            {
                if (app != null)
                {
                    app.Quit();
                }
            }
            catch (Exception ex)
            {
                LogError("Quit Excel", ex);
            }

            ReleaseExcelObject(range);
            ReleaseExcelObject(workSheet);
            ReleaseExcelObject(workBook);
            ReleaseExcelObject(app);

            range = null;
            workSheet = null;
            workBook = null;
            app = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void ReleaseExcelObject(object excelObject)
        {
            if (excelObject == null || !Marshal.IsComObject(excelObject))
            {
                return;
            }

            try
            {
                Marshal.FinalReleaseComObject(excelObject);
            }
            catch (Exception ex)
            {
                LogError("Release Excel COM object", ex);
            }
        }

        private static void LogError(string operation, Exception exception)
        {
            Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) +
                " | " + operation + " | " + exception);
        }

    }

    /*====================================================================================================*/
    /*-----------------------------------------Class Ext.Config-------------------------------------------*/

    internal class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }
    }
}

//Update : 27/10/2021 14:02:00 PM
//Coming up Next--------------------------------
//  - Insert data format each program to data table -- OK 1/9/2021
//  - logging data as table to CSV -- OK 15/9/2021
//  - fileOpen -- OK 25/9/2021 (Open xlsx,csv,txt)
//  - fileSave
//  - fileSaveAs -- OK 25/9/2021 (Same export)
//  - Help,Info
//  - ini config -- OK 1/9/2021
//  - user login
//  - pre load progress
//  - sync progress bar with work -- Remove
//  - manual test program -- OK 3/9/2021
//  - Add data in cell -- OK 13/9/2021
//  - Add manual DC-source -- OK 17/09/2021
//  - setpoint screen -- OK 17/09/2021
//  - setpoint -- OK 17/09/2021
//  - Measure screen
//  - Port can connect but data not match -- OK 25/09/2021 (Add /r/n)
//  - Start Stop button / Disable connection tool -- OK 25/09/2021
//  - User Off DC-Source without getdata >>> Table will not written -- OK 25/09/2021 (Use rtbIncoming2 to check) -- Edit
//  - Assign and arrange Tabindex to any filling box --> 25/09/2021
//  - Add database open button and toolstrip -- 25/09/2021
//  - Change Config port to open config.ini -- 25/09/2021
//  - Edit dc manual panel size to capatible with notebook -- OK 26/09/2021
//  - Add port2 for support DMM and edit config.ini file -- OK 27/09/2021
//  - Use rtbIncoming1 for Port1,rtbIncoming2 for Port2 -- OK 27/09/2021
//  - Add clear latest data in gridTable1 -- OK 27/09/2021
//  - Get data in port 2 (simulation by arduino) and log to table when off DC-Source -- OK 27/09/2021
//  - Edit log data in gridTable1 not log over item existing -- OK 27/09/2021
//  - New DC manual and add DMM manual with command box,identify box -- OK 28/09/2021
//  - Command DMM(port2) 600mS by use dangerTime when on DC-Source -- OK 28/09/2021
//  - Get data convert format EX.+2.37400000E-02 --> 23.740 mV -- OK 28/09/2021
//  - Identify DMM have value --> Use manual
//  - Get set point from database to automatic set and send to comPort1 -- OK 28/09/2021
//  - Clean and Check every grammar and comment -- OK 28/09/2021
//  - Add delay 1 sec of DC setpoint command after select program by use Thread.sleep -- OK 29/09/2021
//  - Add trimSN to use last 4 character -- OK 29/09/2021
//  - Add auto export after stop program -- OK 29/09/2021
//  - Add "'" before SN when export to Excel to keep in format -- OK 29/09/2021
//  - Reset cntRow when Stop program -- OK 29/09/2021
//  - Add auto complete source tbSn and increase limit lenght -- OK 29/09/2021
//  - Add Warning popup when turn on over 10 sec -- Remove
//  - increase Contact pairs width cells -- OK 30/09/2021
//  - Edit export button cannot export and add finish popup when export finish -- OK 30/09/2021
//  - Add help >>> Spec (BMW,OBC,DCB,5DH,NISSAN) information dialog -- OK 30/09/2021
//  - Add popup inform tester after the last test is finish (Testing Done.) -- OK 1/10/2021
//  - Add auto complete SN and first program select -- OK 6/10/2021
//  - Add aboutPE -- OK 7/10/2021
//  - Add button to cal date <--> setting.default -- OK 8/10/2021
//  - Edit dataGrid1 auto scroll
//  - Increase timer 600-->650 to avoid DMM error -- OK 11/10/2021
//  - Add try catch to tbSN -- OK 22/10/2021