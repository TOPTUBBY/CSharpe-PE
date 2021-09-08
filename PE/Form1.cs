////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: peTest.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 24/8/2021 12:00:00 PM
//Last Modified On : 3/9/2021 18:38:00 PM
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
        IniFile ini = new IniFile(@"d:\\config.ini");
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
        _Application app;
        _Workbook workBook;
        _Worksheet workSheet;
        Range range;
        string projSheet;
        string programName;

        public peTest()
        {
            InitializeComponent();
            comPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            connect.Visible = false;
            disConnect.Visible = true;
            dangerTime.Stop();
            toolStripStatusLabel.Text = "Device not connected";
        }

        /*====================================================================================================*/
        /*--------------------------------------------SerialPort----------------------------------------------*/

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
            catch(Exception ex)
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
                btnScan.Enabled = false;
                cbbPort.Enabled = false;
                cbbBaud.Enabled = false;
                testProgram.Enabled = true;
                statusBox.BackColor = Color.LawnGreen;
                notifySerial.Icon = SystemIcons.Application;
                notifySerial.BalloonTipText = cbbPort.Text + "  has been Connected";
                notifySerial.ShowBalloonTip(1000);
                toolStripStatusLabel.Text = "Ready";
                //for(int i = 0; i <= 1; i++) 
                //{ 
                //    Console.Beep();
                //    Thread.Sleep(0); 
                //}  
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
                btnScan.Enabled = true;
                cbbPort.Enabled = true;
                cbbBaud.Enabled = true;
                toolStripStatusLabel.Text = "Device not connected";
                rtbIncoming1.Clear();
                statusBox.BackColor = Color.Red;
                notifySerial.Icon = SystemIcons.Application;
                notifySerial.BalloonTipText = cbbPort.Text + "  has been Disconnected";
                notifySerial.ShowBalloonTip(1000);
            }
        }

        /*====================================================================================================*/
        /*-------------------------------------------Read Port------------------------------------------------*/
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {

            InputData = comPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText1), new object[] { InputData });
            }
        }

        private void SetText1(string text)
        {
            this.rtbIncoming1.Text = text;
            if (rtbIncoming1.Text == "0\n" || rtbIncoming1.Text == "1\n")
            {
                value.Text = "----.--";
            }
            else
            {
                value.Text = rtbIncoming1.Text;
                rtbIncoming2.Text += rtbIncoming1.Text;
            }

            if (rtbIncoming1.Text == "1\n")
            {
                pushStart.Text = "Push foot button to Stop ...";
                pushStart.ForeColor = Color.Red;
                pushData.Visible = true;
                toolStripStatusLabel.Text = "Testing...";
                dangerTime.Start();
            }
            else if (rtbIncoming1.Text == "0\n")
            {
                pushStart.Visible = true;
                pushData.Visible = false;
                warning.Visible = false;
                dangerOn.Visible = false;
                exportTool.Enabled = true;
                pushStart.Text = "Push foot button to Start ...";
                pushStart.ForeColor = Color.RoyalBlue;
                toolStripStatusLabel.Text = "Ready";
                dangerTime.Stop();
            }
        }

        /*====================================================================================================*/
        /*------------------------------------------Select Program--------------------------------------------*/
        //Auto insert program
        private void programList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            programName = programList.Text;
            if (programName == "BMW")
            {
                projSheet = "bmw";
            }
            else if (programName == "DAIMLER	- OBC")
            {
                projSheet = "obc";
            }
            else if (programName == "DAIMLER	- DC Box 1.2")
            {
                projSheet = "dcb1.2";
            }
            else if (programName == "DAIMLER	- DC Box 1.2H")
            {
                projSheet = "dcb1.2h";
            }
            else if (programName == "DAIMLER	- DC Box 2.0")
            {
                projSheet = "dcb2.0";
            }
            else if (programName == "RENAULT	- 5DH")
            {
                projSheet = "5dh";
            }
            else if (programName == "NISSAN	- OBC")
            {
                projSheet = "nissan";
            }
            else
            {
                projSheet = "custom";
            }
        }

        private void confirmSelectBtn_Click(object sender, EventArgs e)
        {
            setPoint.Enabled = true;
            start.Enabled = true;
            getData.Enabled = true;
            dataTable1.Enabled = true;
            gridTable1.Rows.Clear();
            try
            {
                //Disable interface while load test program
                confirmSelectBtn.Enabled = false;
                setPoint.Enabled = false;
                //-----------------------------------------
                app = new Microsoft.Office.Interop.Excel.Application();
                workBook = app.Workbooks.Open("d:/pe_database.xlsx");
                workSheet = workBook.Worksheets[projSheet];
                range = workSheet.UsedRange;

                //Start Importing from the second row. Since the first row is column header
                for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < range.Rows.Count + 1; excelWorkSheetRowIndex++)
                {
                    gridTable1.Rows.Add(workSheet.Cells[excelWorkSheetRowIndex, 1].Value, workSheet.Cells[excelWorkSheetRowIndex, 2].Value);
                }
                //Enable to normal
                confirmSelectBtn.Enabled = true;
                setPoint.Enabled = true;
                //-----------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            workBook.Save();
            workBook.Close();
        }

        //Manual insert program
        private void insertBtn_Click(object sender, EventArgs e)
        {
            for (int gridTable2RowIndex = 2; gridTable2RowIndex < range.Rows.Count + 1; gridTable2RowIndex++)
            {
                gridTable1.Rows.Add(workSheet.Cells[gridTable2RowIndex, 1].Value, workSheet.Cells[gridTable2RowIndex, 2].Value);
            }
        }
        private void cleatBtn_Click(object sender, EventArgs e)
        {
            gridTable2.Rows.Clear();
        }

        /*====================================================================================================*/
        /*--------------------------------------------Setpoint------------------------------------------------*/
        //Button Click to set
        private void setVoltBtn_Click(object sender, EventArgs e)
        {
            pushStart.Visible = true;
            string volt = "v," + voltBox.Text;
            string voltSent;
            int Length, j = 0;

            Length = volt.Length;

            for (int i = 0; i < Length; i++)
            {
                voltSent = volt.Substring(j, 1);
                comPort1.Write(voltSent);
                j++;
            }
        }

        private void setCurrBtn_Click(object sender, EventArgs e)
        {
            pushStart.Visible = true;
            string curr = "a," + currBox.Text;
            string currSent;
            int Length, j = 0;

            Length = curr.Length;

            for (int i = 0; i < Length; i++)
            {
                currSent = curr.Substring(j, 1);
                comPort1.Write(currSent);
                j++;
            }
        }
        //Enter to set
        private void voltBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pushStart.Visible = true;
                string volt = "v," + voltBox.Text;
                string voltSent;
                int Length, j = 0;

                Length = volt.Length;

                for (int i = 0; i < Length; i++)
                {
                    voltSent = volt.Substring(j, 1);
                    comPort1.Write(voltSent);
                    j++;
                }
            }
        }

        private void currBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pushStart.Visible = true;
                string curr = "a," + currBox.Text;
                string currSent;
                int Length, j = 0;

                Length = curr.Length;

                for (int i = 0; i < Length; i++)
                {
                    currSent = curr.Substring(j, 1);
                    comPort1.Write(currSent);
                    j++;
                }
            }
        }

        /*====================================================================================================*/
        /*-------------------------------------------DangerSign------------------------------------------------*/
        void dangerTime_Tick(object sender, EventArgs e)
        {
            dangerOn.Visible = !dangerOn.Visible;
            pushStart.Visible = !pushStart.Visible;
            pushData.Visible = !pushData.Visible;
            warning.Visible = !warning.Visible;
        }

        /*====================================================================================================*/
        /*----------------------------------------------Interface---------------------------------------------*/

        //Auto Connect
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String _port = ini.IniReadValue("CONFIG", "PORT");
                String _baud = ini.IniReadValue("CONFIG", "BAUDRATE");
                comPort1.PortName = _port;
                comPort1.BaudRate = int.Parse(_baud);
                comPort1.Open();
                serialPort.Visible = false;
                btnState.Text = "Disconnect";
                btnScan.Enabled = false;
                cbbPort.Enabled = false;
                cbbBaud.Enabled = false;
                connect.Visible = true;
                disConnect.Visible = false;
                testProgram.Visible = true;
                toolStripStatusLabel.Text = "Ready";
                statusBox.BackColor = Color.LawnGreen;
                notifySerial.Icon = SystemIcons.Application;
                notifySerial.BalloonTipText = cbbPort.Text + "  has been Connected";
                notifySerial.ShowBalloonTip(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please confirm your device port setting." + "\n" + "Configuration at d:\\config.ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnState.Enabled = false;
                testProgram.Enabled = false;
                toolStripStatusLabel.Text = "Device not connected";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comPort1.Close();
        }
        //Menu Strip
        private void fileExit_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "PE Testing");
            comPort1.Close();
        }

        private void configPort_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            start.Visible = false;
            getData.Visible = false;
            dataTable1.Visible = false;
            dataTable2.Visible = false;
            serialPort.Visible = true;
            serialPort.Location = new System.Drawing.Point(12, 11);
        }

        private void configEdit_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            start.Visible = false;
            getData.Visible = false;
            dataTable1.Visible = false;
            dataTable2.Visible = true;
            dataTable2.Height = 450;
            dataTable2.Location = new System.Drawing.Point(12, 11);
            serialPort.Visible = false;
        }
        //Tool Strip
        private void homeTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = true;
            setPoint.Visible = true;
            start.Visible = true;
            getData.Visible = true;
            dataTable1.Visible = true;
            dataTable2.Visible = false;
            serialPort.Visible = false;
        }

        private void editTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            start.Visible = false;
            getData.Visible = false;
            dataTable1.Visible = false;
            dataTable2.Visible = true;
            dataTable2.Height = 450;
            dataTable2.Location = new System.Drawing.Point(12, 11);
            serialPort.Visible = false;
        }

        private void connectionTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            start.Visible = false;
            getData.Visible = false;
            dataTable1.Visible = false;
            dataTable2.Visible = false;
            serialPort.Visible = true;
            serialPort.Location = new System.Drawing.Point(12, 11);
        }

        private void exportTool_Click(object sender, EventArgs e)
        {
            if (saveData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(saveData.FileName));
                write.Write("Project : " + "," + programList.Text + "\n");
                write.Write("Serial No. : " + "," + tbSn.Text + "\n");
                write.Dispose();
                
            }
        }

        private void shutdownTool_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "PE Testing");
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
//Update : 18:38    3/09/2021
//Coming up Next--------------------------------
//- Insert data format each program to data table --> pointer -- OK 1/9/2021
//- logging data as table to CSV
//- fileOpen,fileSave,fileSaveAs,help --> Defined
//- ini config -- OK 1/9/2021
//- user login
//- pre load progress
//- sync progress bar with work
//- manual test program -- OK 3/9/2021

