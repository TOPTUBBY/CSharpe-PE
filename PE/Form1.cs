﻿////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: peTest.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 24/8/2021 12:00:00 PM
//Last Modified On : 17/9/2021 18:44:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
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
        int cntRow = 0;
        decimal resMax = 0;
        decimal measValue;
        decimal voltValue = 0;
        decimal resValue = 0;
        decimal currValue = 0;
        decimal powValue = 0;
        string resultValue;

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
            catch (Exception ex)
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
                toolStripStatusLabel2.Text = comPort1.PortName + "," + comPort1.BaudRate;
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
                toolStripStatusLabel2.Text = null;
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
            if (rtbIncoming1.Text == "0\r\n" || rtbIncoming1.Text == "1\r\n")
            {
                value.Text = "----.--";
            }
            else
            {
                value.Text = rtbIncoming1.Text;
                measValue = Convert.ToDecimal(value.Text); //Measure voltage

                //log all 
                //rtbIncoming2.Text += rtbIncoming1.Text;
            }

            if (rtbIncoming1.Text == "1\r\n")
            {
                pushStart.Text = "Push foot button to Stop ...";
                pushStart.ForeColor = Color.Red;
                pushData.Visible = true;
                toolStripStatusLabel.Text = "Testing...";
                dangerTime.Start();
                testProgram.Enabled = false;
                setPoint.Enabled = false;
                manualTool.Enabled = false;
                this.Text = "PE TESTING (RUNNING)";
            }
            else if (rtbIncoming1.Text == "0\r\n")
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
                testProgram.Enabled = true;
                setPoint.Enabled = true;
                manualTool.Enabled = true;
                this.Text = "PE TESTING";

                //Add check condition if have get data then do, if not just off DC-source
                /*if ()
                {

                }*/

                try
                {
                    //Cells Manangement
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

        /*====================================================================================================*/
        /*------------------------------------------Select Program--------------------------------------------*/
        //Auto insert program
        private void programList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            programName = programList.Text;
            if (programName == "BMW	- CCU")
            {
                projSheet = "bmw";
            }
            else if (programName == "DAIMLER    - OBC")
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
            gridTable1.Rows.Clear();
            foreach (DataGridViewRow row in gridTable2.Rows)
            {
                gridTable1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
            }
            //Back to Home
            testProgram.Visible = true;
            setPoint.Visible = true;
            start.Visible = true;
            getData.Visible = true;
            dataTable1.Visible = true;
            dataTable2.Visible = false;
            serialPort.Visible = false;
            //Enable test
            setPoint.Enabled = true;
            start.Enabled = true;
            getData.Enabled = true;
        }

        private void cleatBtn_Click(object sender, EventArgs e)
        {
            gridTable2.Rows.Clear();
        }

        /*====================================================================================================*/
        /*--------------------------------------------DC Source-----------------------------------------------*/
        //Auto DC source --------------------------------------------------------------------------------------
        //Button Click to set
        private void btnSetVolt_Click(object sender, EventArgs e)
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

        private void btnSetCurr_Click(object sender, EventArgs e)
        {
            pushStart.Visible = true;
            string curr = "a," + currBox.Text;
            string currSent;
            int Length, j = 0;

            currValue = currBox.Value;
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

                currValue = currBox.Value;
                Length = curr.Length;

                for (int i = 0; i < Length; i++)
                {
                    currSent = curr.Substring(j, 1);
                    comPort1.Write(currSent);
                    j++;
                }
            }
        }

        //Manual DC source-------------------------------------------------------------------------------------
        //Button Click to set
        private void btnSetVoltManual_Click(object sender, EventArgs e)
        {
            string volt = "v," + voltBoxManual.Text;
            string voltSent;
            int Length, j = 0;

            voltValue = voltBoxManual.Value;
            Length = volt.Length;

            for (int i = 0; i < Length; i++)
            {
                voltSent = volt.Substring(j, 1);
                comPort1.Write(voltSent);
                j++;
            }
            setVoltScr.Text = String.Format("{0:0.00}", voltBoxManual.Value);
            powValue = voltValue * currValue;
            showPowScr.Text = String.Format("{0:0.0}", powValue);
        }

        private void btnSetCurrManual_Click(object sender, EventArgs e)
        {
            string curr = "a," + currBoxManual.Text;
            string currSent;
            int Length, j = 0;

            currValue = currBoxManual.Value;
            Length = curr.Length;

            for (int i = 0; i < Length; i++)
            {
                currSent = curr.Substring(j, 1);
                comPort1.Write(currSent);
                j++;
            }
            setCurrScr.Text = String.Format("{0:0.00}", currBoxManual.Value);
            powValue = voltValue * currValue;
            showPowScr.Text = String.Format("{0:0.0}", powValue);
        }

        //Enter to set
        private void voltBoxManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string volt = "v," + voltBoxManual.Text;
                string voltSent;
                int Length, j = 0;

                voltValue = voltBoxManual.Value;
                Length = volt.Length;

                for (int i = 0; i < Length; i++)
                {
                    voltSent = volt.Substring(j, 1);
                    comPort1.Write(voltSent);
                    j++;
                }
                setVoltScr.Text = String.Format("{0:0.00}", voltBoxManual.Value);
            }
            powValue = voltValue * currValue;
            showPowScr.Text = String.Format("{0:0.0}", powValue);
        }

        private void currBoxManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string curr = "a," + currBoxManual.Text;
                string currSent;
                int Length, j = 0;

                currValue = currBoxManual.Value;
                Length = curr.Length;

                for (int i = 0; i < Length; i++)
                {
                    currSent = curr.Substring(j, 1);
                    comPort1.Write(currSent);
                    j++;
                }
                setCurrScr.Text = String.Format("{0:0.00}", currBoxManual.Value);
            }
            powValue = voltValue * currValue;
            showPowScr.Text = String.Format("{0:0.0}", powValue);
        }

        private void btnToggleOff_Click(object sender, EventArgs e)
        {
            btnToggleOff.Visible = false;
            btnToggleOn.Visible = true;
            lblToggleOff.Visible = false;
            lblToggleOn.Visible = true;
            this.Text = "PE TESTING (OUTPUT ON)";

            comPort1.Write("1");
        }

        private void btnToggleOn_Click(object sender, EventArgs e)
        {
            btnToggleOn.Visible = false;
            btnToggleOff.Visible = true;
            lblToggleOn.Visible = false;
            lblToggleOff.Visible = true;
            this.Text = "PE TESTING";

            comPort1.Write("0");
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
                toolStripStatusLabel2.Text = comPort1.PortName + "," + comPort1.BaudRate;
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
                toolStripStatusLabel2.Text = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comPort1.Close();
        }
        //Menu Strip
        //File open Menu
        //
        //File save Menu
        //
        //File saveAs Menu
        //
        //File exit Menu
        //
        private void fileExit_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "PE Testing");
            comPort1.Close();
        }

        //Config port Menu
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
            manual.Visible = false;
        }

        //Config edit Menu
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
            manual.Visible = false;
        }

        //Tool Strip
        //Home button
        private void homeTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = true;
            setPoint.Visible = true;
            start.Visible = true;
            getData.Visible = true;
            dataTable1.Visible = true;
            dataTable2.Visible = false;
            serialPort.Visible = false;
            manual.Visible = false;
        }

        //Edit button
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
            manual.Visible = false;
        }

        //Connection button
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
            manual.Visible = false;
        }

        //Manual button
        private void manualTool_Click(object sender, EventArgs e)
        {
            testProgram.Visible = false;
            setPoint.Visible = false;
            start.Visible = false;
            getData.Visible = false;
            dataTable1.Visible = false;
            dataTable2.Visible = false;
            serialPort.Visible = false;
            manual.Visible = true;
            manual.Location = new System.Drawing.Point(12, 11);
            manual.Size = new System.Drawing.Size(958, 491);
        }

        //Export button
        private void exportTool_Click(object sender, EventArgs e)
        {
            try
            {
                workBook = app.Workbooks.Add(1);
                workSheet = workBook.ActiveSheet;
                workSheet.Name = "PE";

                workSheet.Cells[1, 1] = "Project";
                workSheet.Cells[1, 2] = programList.Text;
                workSheet.Cells[2, 1] = "Serial No.";
                workSheet.Cells[2, 2] = tbSn.Text;
                workSheet.Cells[3, 1] = "Test Date";
                workSheet.Cells[3, 2] = System.DateTime.Now;
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
                if (saveData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workBook.SaveAs(saveData.FileName);
                }
                app.Quit();
                workBook = null;
                workSheet = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Shutdown button
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
//Update : 17/9/2021 18:44:00 PM
//Coming up Next--------------------------------
//- Insert data format each program to data table --> pointer -- OK 1/9/2021
//- logging data as table to CSV -- OK 15/9/2021
//- fileOpen,fileSave,fileSaveAs,help 
//- ini config -- OK 1/9/2021
//- user login
//- pre load progress 
//- sync progress bar with work 
//- manual test program -- OK 3/9/2021
//- Add data in cell -- OK 13/9/2021
//- Add manual DC-source -- On-Going
//  - setpoint screen -- OK 17/09/2021
//  - setpoint -- OK 17/09/2021
//  - Measure screen
//  - Port can connect but data not match**

