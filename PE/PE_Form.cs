////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: peTest.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 24/8/2021 12:00:00 PM
//Last Modified On : 30/9/2021 08:13:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PE
{
    public partial class peTest : Form
    {
        IniFile ini = new IniFile(@"D:\\config.ini");
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
        _Application app;
        _Workbook workBook;
        _Worksheet workSheet;
        Range range;
        string projSheet;
        string programName;
        string trimSN;
        int cntRow = 0;
        decimal resMax = 0;
        decimal measValue;
        decimal voltValue = 0;
        decimal resValue = 0;
        decimal currValue = 0;
        string resultValue;


        public peTest()
        {
            InitializeComponent();
            comPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            comPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_2);
            dangerTime.Stop();
            toolStripStatusLabel.Text = "Device not connected";
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
            InputData = comPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText1), new object[] { InputData });
            }
        }

        private void SetText1(string text1)
        {
            this.rtbIncoming1.Text = text1;
            if (rtbIncoming1.Text == "0\r\n" || rtbIncoming1.Text == "1\r\n")
            {
                value.Text = "---.---";
            }
            else
            {
                tbIdentDC.Text = rtbIncoming1.Text;
            }

            if (rtbIncoming1.Text == "1\r\n")
            {
                this.rtbIncoming2.Text = null;
                this.Text = "PE TESTING (RUNNING)";
                testProgram.Enabled = false;
                setPoint.Enabled = false;
                manualTool.Enabled = false;
                pushStart.Text = "Push foot button to Stop ...";
                pushStart.ForeColor = Color.Red;
                dangerTime.Start();
                toolStripStatusLabel.Text = "Testing...";
            }
            else if (rtbIncoming1.Text == "0\r\n")
            {
                this.Text = "PE TESTING";
                testProgram.Enabled = true;
                setPoint.Enabled = true;
                manualTool.Enabled = true;
                fileSaveAs.Enabled = true;
                exportTool.Enabled = true;
                pushStart.Visible = true;
                warning.Visible = false;
                dangerOn.Visible = false;
                pushStart.Text = "Push foot button to Start ...";
                pushStart.ForeColor = Color.RoyalBlue;
                dangerTime.Stop();
                toolStripStatusLabel.Text = "Ready";

                if (gridTable1.Rows[cntRow].Cells[0].Value != null)
                {
                    if (rtbIncoming2.Text != null)
                    {
                        //Cells Manangement
                        //Add data in voltage cell
                        try
                        {
                            //Add data in voltage cell
                            gridTable1.Rows[cntRow].Cells[2].Value = measValue;

                            //Calculate to Resistance by use Current from setpoint
                            //Add data in resistance cell
                            voltValue = Convert.ToDecimal(measValue);
                            resValue = voltValue / currValue;
                            gridTable1.Rows[cntRow].Cells[3].Value = resValue;

                            //Add data in result cell
                            resMax = Convert.ToDecimal(gridTable1.Rows[cntRow].Cells[1].Value);
                            var _color = Color.Black;
                            if (resValue <= resMax)
                            {
                                resultValue = "PASS";
                                _color = Color.Green;

                            }
                            else
                            {
                                resultValue = "FAIL";
                                _color = Color.Red;
                            }
                            gridTable1.Rows[cntRow].Cells[4].Value = resultValue;
                            gridTable1.Rows[cntRow].Cells[4].Style.ForeColor = _color;
                            cntRow++;
                        }
                        catch
                        {
                            resValue = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Done !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Clear Lastest data in gridTable1
        private void btnClearData_Click(object sender, EventArgs e)
        {
            try
            {
                gridTable1.Rows[cntRow - 1].Cells[2].Value = null;
                gridTable1.Rows[cntRow - 1].Cells[3].Value = null;
                gridTable1.Rows[cntRow - 1].Cells[4].Value = null;
                cntRow--;
            }
            catch
            {
                MessageBox.Show("Data unavailable to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /*-------------------------------------------Read Port2-----------------------------------------------*/
        private void port_DataReceived_2(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = comPort2.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText2), new object[] { InputData });
            }
        }

        private void SetText2(string text2)
        {
            this.rtbIncoming2.Text = text2;
            try
            {
                string trimStart = rtbIncoming2.Text.TrimStart('+', '-');
                string trimEnd = trimStart.Replace("\r\n", string.Empty);
                decimal decimalValue = Decimal.Parse(trimEnd, System.Globalization.NumberStyles.Any);
                decimal milliValue = decimalValue * 1000;
                string finalValue = milliValue.ToString("0.000");

                value.Text = finalValue;
                valueDMM.Text = finalValue;
                measValue = Convert.ToDecimal(value.Text); //Measure voltage
            }
            catch
            {

            }
        }

        /*====================================================================================================*/
        /*------------------------------------------Select Program--------------------------------------------*/
        //Auto insert program
        private void programList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            programName = programList.Text;
            if (programName == "BMW	- CCU")
            {
                projSheet = "BMW";
            }
            else if (programName == "DAIMLER	- OBC")
            {
                projSheet = "DAI_OBC";
            }
            else if (programName == "DAIMLER	- DC Box 1.2")
            {
                projSheet = "DAI_DCB1.2";
            }
            else if (programName == "DAIMLER	- DC Box 1.2H")
            {
                projSheet = "DAI_DCB1.2H";
            }
            else if (programName == "DAIMLER	- DC Box 2.0")
            {
                projSheet = "DAI_DCB2.0";
            }
            else if (programName == "RENAULT	- 5DH")
            {
                projSheet = "REN_5DH";
            }
            else if (programName == "NISSAN	- OBC")
            {
                projSheet = "NISSAN_OBC";
            }
            else
            {
                projSheet = "CUSTOM";
            }
        }

        private void tbSn_Click(object sender, EventArgs e)
        {
            tbSn.Text = null;
        }

        private void confirmSelectBtn_Click(object sender, EventArgs e)
        {
            gridTable1.Rows.Clear();
            try
            {
                //Disable interface while load test program
                confirmSelectBtn.Enabled = false;
                setPoint.Enabled = false;

                app = new Microsoft.Office.Interop.Excel.Application();
                workBook = app.Workbooks.Open(@"D:/pe_database.xlsx");
                workSheet = workBook.Worksheets[projSheet];
                range = workSheet.UsedRange;

                //Start Importing from the second row. Since the first row is column header
                for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < range.Rows.Count + 1; excelWorkSheetRowIndex++)
                {
                    gridTable1.Rows.Add(workSheet.Cells[excelWorkSheetRowIndex, 1].Value, workSheet.Cells[excelWorkSheetRowIndex, 2].Value);
                }

                //Get setpoint from database
                double dbSetVolt = workSheet.Cells[2, 3].Value;
                double dbSetCurr = workSheet.Cells[2, 4].Value;
                comPort1.Write("v," + dbSetVolt + "\r\n");
                System.Threading.Thread.Sleep(2000);    //Delay command 2 sec
                comPort1.Write("a," + dbSetCurr + "\r\n");
                System.Threading.Thread.Sleep(1000);    //Delay command 1 sec
                comPort1.Write("*cls\r\n");
                voltBox.Value = Convert.ToInt32(dbSetVolt);
                currBox.Value = Convert.ToInt32(dbSetCurr);
                currValue = currBox.Value;

                //Enable to normal
                confirmSelectBtn.Enabled = true;
                setPoint.Enabled = true;

                //trim SN
                trimSN = tbSn.Text.Substring(tbSn.Text.Length - 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            workBook.Close();
            app.Quit();
        }

        //Manual insert program
        private void insertBtn_Click(object sender, EventArgs e)
        {
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

            //Enable test
            setPoint.Enabled = true;
            startTesting.Enabled = true;
            getData.Enabled = true;
        }

        private void cleatBtn_Click(object sender, EventArgs e)
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
                comPort1.Write("*idn?\r\n");
                System.Threading.Thread.Sleep(2000);    //Delay command 2 sec
                comPort1.Write("comf:rem\r\n");
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

            comPort1.Write("1\r\n");
        }

        private void btnToggleOn_Click(object sender, EventArgs e)
        {
            this.Text = "PE TESTING";
            btnToggleOn.Visible = false;
            btnToggleOff.Visible = true;
            lblToggleOn.Visible = false;
            lblToggleOff.Visible = true;

            comPort1.Write("0\r\n");
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
            valueDMM.Text = "---.---";
            pushStart.Visible = false;
            warning.Visible = false;
            dangerOn.Visible = false;
        }

        /*====================================================================================================*/
        /*-----------------------------------------DangerSign/Run---------------------------------------------*/
        void dangerTime_Tick(object sender, EventArgs e)
        {
            try
            {
                comPort2.Write("meas:volt:dc?\r\n");
            }
            catch
            {

            }
            dangerOn.Visible = !dangerOn.Visible;
            pushStart.Visible = !pushStart.Visible;
            warning.Visible = !warning.Visible;
        }

        /*====================================================================================================*/
        /*----------------------------------------------Interface---------------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Device not connected";
            lblDCPort.Text = null;
            lblDMMPort.Text = null;
            dangerTime.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }

        //File Open Menu
        private void fileOpen_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FilterIndex == 1)
                {
                    path = openFile.FileName;
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(path);
                    app.Visible = true;
                }
                else if (openFile.FilterIndex == 2)
                {
                    path = openFile.FileName;
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(path);
                    app.Visible = true;
                }
                else
                {
                    path = openFile.FileName;
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        //File Save Menu
        private void fileSave_Click(object sender, EventArgs e)
        {

        }

        //File Save As Menu
        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                workBook = app.Workbooks.Add(1);
                workSheet = workBook.ActiveSheet;
                workSheet.Name = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

                workSheet.Cells[1, 1] = "Project";
                workSheet.Cells[1, 2] = programList.Text;
                workSheet.Cells[2, 1] = "Serial No.";
                workSheet.Cells[2, 2] = "'" + tbSn.Text;
                workSheet.Cells[3, 1] = "Test Date";
                workSheet.Cells[3, 2] = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                // header
                for (int i = 1; i <= gridTable1.Columns.Count; i++)
                {
                    workSheet.Cells[4, i] = gridTable1.Columns[i - 1].HeaderText;
                }

                // data
                for (int i = 1; i <= gridTable1.RowCount; i++)
                {
                    for (int j = 1; j <= gridTable1.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 4, j] = gridTable1.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                string root = @"D:\PE_DATA";
                // If directory does not exist, create it. 
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                saveData.FileName = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                if (saveData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workBook.SaveAs(saveData.FileName);
                    MessageBox.Show("Report Generated.", "PE TESTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                app.Quit();
                workBook = null;
                workSheet = null;
                fileSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //File exit Menu
        private void fileExit_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "PE TESTING");
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }

        //Config port Menu 
        private void configPort_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:/config.ini");
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
            app = new Microsoft.Office.Interop.Excel.Application();
            workBook = app.Workbooks.Open(@"D:/pe_database.xlsx");
            app.Visible = true;
        }

        //Help >>> Spec
        private void helpSpecBMW_Click(object sender, EventArgs e)
        {
            specBMW.Show("BMW Specification");
        }

        private void helpSpecOBC_Click(object sender, EventArgs e)
        {
            specOBC.Show("DAIMLER-OBC Specification");
        }

        private void helpSpecDCB_Click(object sender, EventArgs e)
        {
            specDCB.Show("DAIMLER-DC Box Specification");
        }

        private void helpSpecREN_Click(object sender, EventArgs e)
        {
            specREN.Show("Renault 5DH Specification");
        }

        private void helpSpecNIS_Click(object sender, EventArgs e)
        {
            specNIS.Show("Nissan OBC Specification");
        }

        //Tool Strip
        //Start button
        private void startTool_Click(object sender, EventArgs e)
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

                //Port1-DC
                comPort1.RtsEnable = false;
                comPort1.DtrEnable = false;
                comPort1.Close();

                //Port2-DMM
                comPort2.RtsEnable = false;
                comPort2.DtrEnable = false;
                comPort2.Close();

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
                warning.Visible = false;
                dangerOn.Visible = false;
                pushStart.Text = "Push foot button to Start ...";
                pushStart.ForeColor = Color.RoyalBlue;
                dangerTime.Stop();
                getData.Enabled = false;
                testData.Enabled = false;
                manualDC.Enabled = false;
                editSpecTest.Enabled = false;

                //Auto Export
                try
                {
                    workBook = app.Workbooks.Add(1);
                    workSheet = workBook.ActiveSheet;
                    workSheet.Name = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

                    workSheet.Cells[1, 1] = "Project";
                    workSheet.Cells[1, 2] = programList.Text;
                    workSheet.Cells[2, 1] = "Serial No.";
                    workSheet.Cells[2, 2] = "'" + tbSn.Text;
                    workSheet.Cells[3, 1] = "Test Date";
                    workSheet.Cells[3, 2] = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    // header
                    for (int i = 1; i <= gridTable1.Columns.Count; i++)
                    {
                        workSheet.Cells[4, i] = gridTable1.Columns[i - 1].HeaderText;
                    }

                    // data
                    for (int i = 1; i <= gridTable1.RowCount; i++)
                    {
                        for (int j = 1; j <= gridTable1.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 4, j] = gridTable1.Rows[i - 1].Cells[j - 1].Value;
                        }
                    }
                    string root = @"D:\PE_DATA";
                    // If directory does not exist, create it. 
                    if (!Directory.Exists(root))
                    {
                        Directory.CreateDirectory(root);
                    }
                    saveData.FileName = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                    workBook.SaveAs(@"D:\PE_DATA\" + saveData.FileName + ".xlsx");
                    app.Quit();
                    workBook = null;
                    workSheet = null;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            else if (startTool.Text == "Start")
            {
                startTool.Image = new Bitmap(PE.Properties.Resources.icons8_full_stop_48);
                startTool.Text = "Stop";
                connect.Visible = true;
                disConnect.Visible = false;
                toolStripStatusLabel.Text = "Ready";

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
                    testProgram.Enabled = true;
                    setPoint.Enabled = true;
                    startTesting.Enabled = true;
                    manualDC.Enabled = true;

                    //Inintial DC
                    comPort1.Write("*cls\r\n");
                    System.Threading.Thread.Sleep(2000);    //Delay command 2 sec
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
                    testProgram.Enabled = true;
                    getData.Enabled = true;
                    testData.Enabled = true;

                    //Inintial DMM
                    comPort2.Write("*cls\r\n");
                    System.Threading.Thread.Sleep(1000);    //Delay command 1 sec
                    comPort2.Write("syst:rem\r\n");
                }
                catch
                {
                    getData.Enabled = false;
                    testData.Enabled = false;
                    lblDMMPort.Text = comPort2.PortName + "," + comPort2.BaudRate;
                    lblDMMPort.BackColor = Color.Red;
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
            value.Text = "---.---";
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
            app = new Microsoft.Office.Interop.Excel.Application();
            workBook = app.Workbooks.Open(@"D:/pe_database.xlsx");
            app.Visible = true;
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
            try
            {
                workBook = app.Workbooks.Add(1);
                workSheet = workBook.ActiveSheet;
                workSheet.Name = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

                workSheet.Cells[1, 1] = "Project";
                workSheet.Cells[1, 2] = programList.Text;
                workSheet.Cells[2, 1] = "Serial No.";
                workSheet.Cells[2, 2] = "'" + tbSn.Text;
                workSheet.Cells[3, 1] = "Test Date";
                workSheet.Cells[3, 2] = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                // header
                for (int i = 1; i <= gridTable1.Columns.Count; i++)
                {
                    workSheet.Cells[4, i] = gridTable1.Columns[i - 1].HeaderText;
                }

                // data
                for (int i = 1; i <= gridTable1.RowCount; i++)
                {
                    for (int j = 1; j <= gridTable1.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 4, j] = gridTable1.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                string root = @"D:\PE_DATA";
                // If directory does not exist, create it. 
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                saveData.FileName = "PE_SN" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                if (saveData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workBook.SaveAs(saveData.FileName);
                    MessageBox.Show("Report Generated.", "PE TESTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                app.Quit();
                workBook = null;
                workSheet = null;
                fileSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Shutdown button
        private void shutdownTool_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "PE TESTING");
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }
    }

    /*====================================================================================================*/
    /*-----------------------------------------Class Ext.Config-------------------------------------------*/
    class IniFile
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

//Update : 30/9/2021 08:13:00 PM
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


