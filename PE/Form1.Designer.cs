﻿
namespace PE
{
    partial class peTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peTest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.Windows.Forms.GroupBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.rtbIncoming2 = new System.Windows.Forms.RichTextBox();
            this.rtbIncoming1 = new System.Windows.Forms.RichTextBox();
            this.btnState = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.cbbBaud = new System.Windows.Forms.ComboBox();
            this.cbbPort = new System.Windows.Forms.ComboBox();
            this.notifySerial = new System.Windows.Forms.NotifyIcon(this.components);
            this.setPoint = new System.Windows.Forms.GroupBox();
            this.currBox = new System.Windows.Forms.NumericUpDown();
            this.voltBox = new System.Windows.Forms.NumericUpDown();
            this.btnSetCurr = new System.Windows.Forms.Button();
            this.btnSetVolt = new System.Windows.Forms.Button();
            this.lblCurr = new System.Windows.Forms.Label();
            this.lblCurr2 = new System.Windows.Forms.Label();
            this.lblVolt2 = new System.Windows.Forms.Label();
            this.lblVolt = new System.Windows.Forms.Label();
            this.dangerTime = new System.Windows.Forms.Timer(this.components);
            this.pushStart = new System.Windows.Forms.Label();
            this.startTesting = new System.Windows.Forms.GroupBox();
            this.comPort1 = new System.IO.Ports.SerialPort(this.components);
            this.getData = new System.Windows.Forms.GroupBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.lblVolt3 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.testProgram = new System.Windows.Forms.GroupBox();
            this.tbSn = new System.Windows.Forms.TextBox();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblSelectProgram = new System.Windows.Forms.Label();
            this.programList = new System.Windows.Forms.ComboBox();
            this.manualDC = new System.Windows.Forms.GroupBox();
            this.lblDMMPort = new System.Windows.Forms.Label();
            this.lblDCPort = new System.Windows.Forms.Label();
            this.lblShowCurrScr = new System.Windows.Forms.Label();
            this.lblPowScr = new System.Windows.Forms.Label();
            this.lblCurrScr = new System.Windows.Forms.Label();
            this.lblSetCurrScr = new System.Windows.Forms.Label();
            this.lblVoltScr = new System.Windows.Forms.Label();
            this.lblSetVoltScr = new System.Windows.Forms.Label();
            this.lblShowVoltScr = new System.Windows.Forms.Label();
            this.showPowScr = new System.Windows.Forms.TextBox();
            this.setCurrScr = new System.Windows.Forms.TextBox();
            this.showCurrScr = new System.Windows.Forms.TextBox();
            this.setVoltScr = new System.Windows.Forms.TextBox();
            this.showVoltScr = new System.Windows.Forms.TextBox();
            this.lblToggleOn = new System.Windows.Forms.Label();
            this.lblToggleOff = new System.Windows.Forms.Label();
            this.setPointManual = new System.Windows.Forms.GroupBox();
            this.currBoxManual = new System.Windows.Forms.NumericUpDown();
            this.voltBoxManual = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetVoltManual = new System.Windows.Forms.Button();
            this.lblCurrManual = new System.Windows.Forms.Label();
            this.lblCurrManual2 = new System.Windows.Forms.Label();
            this.lblVoltManual2 = new System.Windows.Forms.Label();
            this.lblVoltManual = new System.Windows.Forms.Label();
            this.editSpecTest = new System.Windows.Forms.GroupBox();
            this.cleatBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.gridTable2 = new System.Windows.Forms.DataGridView();
            this.editContactPairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMaxRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testData = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.gridTable1 = new System.Windows.Forms.DataGridView();
            this.contactPairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measVolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveData = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.comPort2 = new System.IO.Ports.SerialPort(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.delta = new System.Windows.Forms.PictureBox();
            this.disConnect = new System.Windows.Forms.PictureBox();
            this.connect = new System.Windows.Forms.PictureBox();
            this.statusBox = new System.Windows.Forms.PictureBox();
            this.confirmSelectBtn = new System.Windows.Forms.Button();
            this.btnToggleOff = new System.Windows.Forms.PictureBox();
            this.chroma = new System.Windows.Forms.PictureBox();
            this.btnToggleOn = new System.Windows.Forms.PictureBox();
            this.warning = new System.Windows.Forms.PictureBox();
            this.dangerOn = new System.Windows.Forms.PictureBox();
            this.danger = new System.Windows.Forms.PictureBox();
            this.dmm34401a = new System.Windows.Forms.PictureBox();
            this.startTool = new System.Windows.Forms.ToolStripButton();
            this.homeTool = new System.Windows.Forms.ToolStripButton();
            this.editTool = new System.Windows.Forms.ToolStripButton();
            this.manualTool = new System.Windows.Forms.ToolStripButton();
            this.databaseTool = new System.Windows.Forms.ToolStripButton();
            this.exportTool = new System.Windows.Forms.ToolStripButton();
            this.shutdownTool = new System.Windows.Forms.ToolStripButton();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.configPort = new System.Windows.Forms.ToolStripMenuItem();
            this.configEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.configManual = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.serialPort.SuspendLayout();
            this.setPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBox)).BeginInit();
            this.startTesting.SuspendLayout();
            this.getData.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupTest.SuspendLayout();
            this.testProgram.SuspendLayout();
            this.manualDC.SuspendLayout();
            this.setPointManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBoxManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBoxManual)).BeginInit();
            this.editSpecTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable2)).BeginInit();
            this.testData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chroma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangerOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmm34401a)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.configToolStripMenu,
            this.helpToolStripMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpen,
            this.fileSave,
            this.fileSaveAs,
            this.fileExit});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // configToolStripMenu
            // 
            this.configToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configPort,
            this.configEdit,
            this.configManual,
            this.databaseToolStripMenuItem});
            this.configToolStripMenu.Name = "configToolStripMenu";
            this.configToolStripMenu.Size = new System.Drawing.Size(93, 20);
            this.configToolStripMenu.Text = "Configuration";
            // 
            // helpToolStripMenu
            // 
            this.helpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpInfo,
            this.helpHelp});
            this.helpToolStripMenu.Name = "helpToolStripMenu";
            this.helpToolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenu.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenu.Text = "Help";
            // 
            // serialPort
            // 
            this.serialPort.Controls.Add(this.statusBox);
            this.serialPort.Controls.Add(this.lblBaud);
            this.serialPort.Controls.Add(this.lblPort);
            this.serialPort.Controls.Add(this.rtbIncoming2);
            this.serialPort.Controls.Add(this.rtbIncoming1);
            this.serialPort.Controls.Add(this.btnState);
            this.serialPort.Controls.Add(this.btnScan);
            this.serialPort.Controls.Add(this.cbbBaud);
            this.serialPort.Controls.Add(this.cbbPort);
            this.serialPort.Enabled = false;
            this.serialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.serialPort.Location = new System.Drawing.Point(990, 11);
            this.serialPort.Name = "serialPort";
            this.serialPort.Size = new System.Drawing.Size(322, 117);
            this.serialPort.TabIndex = 1;
            this.serialPort.TabStop = false;
            this.serialPort.Text = "Connection";
            this.serialPort.Visible = false;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblBaud.Location = new System.Drawing.Point(233, 57);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(75, 20);
            this.lblBaud.TabIndex = 2;
            this.lblBaud.Text = "Baudrate";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPort.Location = new System.Drawing.Point(233, 25);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(75, 20);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Com Port";
            // 
            // rtbIncoming2
            // 
            this.rtbIncoming2.Location = new System.Drawing.Point(6, 232);
            this.rtbIncoming2.Name = "rtbIncoming2";
            this.rtbIncoming2.ReadOnly = true;
            this.rtbIncoming2.Size = new System.Drawing.Size(310, 85);
            this.rtbIncoming2.TabIndex = 2;
            this.rtbIncoming2.Text = "";
            // 
            // rtbIncoming1
            // 
            this.rtbIncoming1.Location = new System.Drawing.Point(6, 140);
            this.rtbIncoming1.Name = "rtbIncoming1";
            this.rtbIncoming1.ReadOnly = true;
            this.rtbIncoming1.Size = new System.Drawing.Size(310, 85);
            this.rtbIncoming1.TabIndex = 2;
            this.rtbIncoming1.Text = "";
            // 
            // btnState
            // 
            this.btnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnState.Location = new System.Drawing.Point(6, 88);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(310, 29);
            this.btnState.TabIndex = 1;
            this.btnState.TabStop = false;
            this.btnState.Text = "Connect";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnScan.Location = new System.Drawing.Point(6, 20);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(96, 62);
            this.btnScan.TabIndex = 1;
            this.btnScan.TabStop = false;
            this.btnScan.Text = "Scan Port";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cbbBaud
            // 
            this.cbbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbBaud.FormattingEnabled = true;
            this.cbbBaud.Location = new System.Drawing.Point(111, 54);
            this.cbbBaud.Name = "cbbBaud";
            this.cbbBaud.Size = new System.Drawing.Size(116, 28);
            this.cbbBaud.TabIndex = 1;
            // 
            // cbbPort
            // 
            this.cbbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbPort.FormattingEnabled = true;
            this.cbbPort.Location = new System.Drawing.Point(111, 20);
            this.cbbPort.Name = "cbbPort";
            this.cbbPort.Size = new System.Drawing.Size(116, 28);
            this.cbbPort.TabIndex = 0;
            // 
            // notifySerial
            // 
            this.notifySerial.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifySerial.BalloonTipTitle = "Warning !!!";
            this.notifySerial.Icon = ((System.Drawing.Icon)(resources.GetObject("notifySerial.Icon")));
            this.notifySerial.Text = "Comport Status";
            // 
            // setPoint
            // 
            this.setPoint.Controls.Add(this.currBox);
            this.setPoint.Controls.Add(this.voltBox);
            this.setPoint.Controls.Add(this.btnSetCurr);
            this.setPoint.Controls.Add(this.btnSetVolt);
            this.setPoint.Controls.Add(this.lblCurr);
            this.setPoint.Controls.Add(this.lblCurr2);
            this.setPoint.Controls.Add(this.lblVolt2);
            this.setPoint.Controls.Add(this.lblVolt);
            this.setPoint.Enabled = false;
            this.setPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.setPoint.Location = new System.Drawing.Point(496, 11);
            this.setPoint.Name = "setPoint";
            this.setPoint.Size = new System.Drawing.Size(474, 117);
            this.setPoint.TabIndex = 3;
            this.setPoint.TabStop = false;
            this.setPoint.Text = "Setpoint";
            // 
            // currBox
            // 
            this.currBox.DecimalPlaces = 2;
            this.currBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.currBox.Increment = new decimal(new int[] {
            500,
            0,
            0,
            262144});
            this.currBox.Location = new System.Drawing.Point(143, 74);
            this.currBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.currBox.Name = "currBox";
            this.currBox.Size = new System.Drawing.Size(128, 26);
            this.currBox.TabIndex = 4;
            this.currBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currBox.ThousandsSeparator = true;
            this.currBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currBox_KeyDown);
            // 
            // voltBox
            // 
            this.voltBox.DecimalPlaces = 2;
            this.voltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.voltBox.Increment = new decimal(new int[] {
            500,
            0,
            0,
            262144});
            this.voltBox.Location = new System.Drawing.Point(143, 29);
            this.voltBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.voltBox.Name = "voltBox";
            this.voltBox.Size = new System.Drawing.Size(128, 26);
            this.voltBox.TabIndex = 3;
            this.voltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.voltBox.ThousandsSeparator = true;
            this.voltBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voltBox_KeyDown);
            // 
            // btnSetCurr
            // 
            this.btnSetCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetCurr.Location = new System.Drawing.Point(325, 70);
            this.btnSetCurr.Name = "btnSetCurr";
            this.btnSetCurr.Size = new System.Drawing.Size(118, 32);
            this.btnSetCurr.TabIndex = 2;
            this.btnSetCurr.TabStop = false;
            this.btnSetCurr.Text = "Set";
            this.btnSetCurr.UseVisualStyleBackColor = true;
            this.btnSetCurr.Click += new System.EventHandler(this.btnSetCurr_Click);
            // 
            // btnSetVolt
            // 
            this.btnSetVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetVolt.Location = new System.Drawing.Point(325, 25);
            this.btnSetVolt.Name = "btnSetVolt";
            this.btnSetVolt.Size = new System.Drawing.Size(118, 32);
            this.btnSetVolt.TabIndex = 2;
            this.btnSetVolt.TabStop = false;
            this.btnSetVolt.Text = "Set";
            this.btnSetVolt.UseVisualStyleBackColor = true;
            this.btnSetVolt.Click += new System.EventHandler(this.btnSetVolt_Click);
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurr.Location = new System.Drawing.Point(67, 76);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(70, 20);
            this.lblCurr.TabIndex = 1;
            this.lblCurr.Text = "Current :";
            // 
            // lblCurr2
            // 
            this.lblCurr2.AutoSize = true;
            this.lblCurr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurr2.Location = new System.Drawing.Point(287, 76);
            this.lblCurr2.Name = "lblCurr2";
            this.lblCurr2.Size = new System.Drawing.Size(20, 20);
            this.lblCurr2.TabIndex = 1;
            this.lblCurr2.Text = "A";
            // 
            // lblVolt2
            // 
            this.lblVolt2.AutoSize = true;
            this.lblVolt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVolt2.Location = new System.Drawing.Point(287, 31);
            this.lblVolt2.Name = "lblVolt2";
            this.lblVolt2.Size = new System.Drawing.Size(20, 20);
            this.lblVolt2.TabIndex = 1;
            this.lblVolt2.Text = "V";
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVolt.Location = new System.Drawing.Point(65, 31);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(72, 20);
            this.lblVolt.TabIndex = 1;
            this.lblVolt.Text = "Voltage :";
            // 
            // dangerTime
            // 
            this.dangerTime.Enabled = true;
            this.dangerTime.Interval = 500;
            this.dangerTime.Tick += new System.EventHandler(this.dangerTime_Tick);
            // 
            // pushStart
            // 
            this.pushStart.AutoSize = true;
            this.pushStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushStart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pushStart.Location = new System.Drawing.Point(64, 28);
            this.pushStart.Name = "pushStart";
            this.pushStart.Size = new System.Drawing.Size(297, 25);
            this.pushStart.TabIndex = 5;
            this.pushStart.Text = "Push foot button to Start ...";
            this.pushStart.Visible = false;
            // 
            // startTesting
            // 
            this.startTesting.Controls.Add(this.warning);
            this.startTesting.Controls.Add(this.dangerOn);
            this.startTesting.Controls.Add(this.pushStart);
            this.startTesting.Controls.Add(this.danger);
            this.startTesting.Enabled = false;
            this.startTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.startTesting.Location = new System.Drawing.Point(12, 134);
            this.startTesting.Name = "startTesting";
            this.startTesting.Size = new System.Drawing.Size(474, 218);
            this.startTesting.TabIndex = 6;
            this.startTesting.TabStop = false;
            this.startTesting.Text = "Start testing";
            // 
            // comPort1
            // 
            this.comPort1.BaudRate = 115200;
            this.comPort1.DtrEnable = true;
            this.comPort1.RtsEnable = true;
            this.comPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived_1);
            // 
            // getData
            // 
            this.getData.Controls.Add(this.lblTestResult);
            this.getData.Controls.Add(this.dmm34401a);
            this.getData.Controls.Add(this.lblVolt3);
            this.getData.Controls.Add(this.value);
            this.getData.Enabled = false;
            this.getData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getData.Location = new System.Drawing.Point(496, 134);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(474, 218);
            this.getData.TabIndex = 6;
            this.getData.TabStop = false;
            this.getData.Text = "Get data from multimeter";
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestResult.Location = new System.Drawing.Point(23, 28);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(90, 20);
            this.lblTestResult.TabIndex = 7;
            this.lblTestResult.Text = "Test Result";
            // 
            // lblVolt3
            // 
            this.lblVolt3.AutoSize = true;
            this.lblVolt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt3.Location = new System.Drawing.Point(345, 134);
            this.lblVolt3.Name = "lblVolt3";
            this.lblVolt3.Size = new System.Drawing.Size(98, 55);
            this.lblVolt3.TabIndex = 6;
            this.lblVolt3.Text = "mV";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.value.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.value.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.SystemColors.MenuText;
            this.value.Location = new System.Drawing.Point(48, 124);
            this.value.MaximumSize = new System.Drawing.Size(275, 75);
            this.value.MinimumSize = new System.Drawing.Size(275, 75);
            this.value.Name = "value";
            this.value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.value.Size = new System.Drawing.Size(275, 75);
            this.value.TabIndex = 6;
            this.value.Text = "----.--";
            this.value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.value.UseCompatibleTextRendering = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTool,
            this.toolStripSeparator6,
            this.homeTool,
            this.toolStripSeparator1,
            this.editTool,
            this.toolStripSeparator2,
            this.manualTool,
            this.toolStripSeparator3,
            this.databaseTool,
            this.toolStripSeparator4,
            this.exportTool,
            this.toolStripSeparator5,
            this.shutdownTool});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(983, 70);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.serialPort);
            this.groupTest.Controls.Add(this.testProgram);
            this.groupTest.Controls.Add(this.manualDC);
            this.groupTest.Controls.Add(this.editSpecTest);
            this.groupTest.Controls.Add(this.testData);
            this.groupTest.Controls.Add(this.setPoint);
            this.groupTest.Controls.Add(this.startTesting);
            this.groupTest.Controls.Add(this.getData);
            this.groupTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupTest.Location = new System.Drawing.Point(0, 94);
            this.groupTest.Name = "groupTest";
            this.groupTest.Size = new System.Drawing.Size(983, 655);
            this.groupTest.TabIndex = 9;
            this.groupTest.TabStop = false;
            // 
            // testProgram
            // 
            this.testProgram.Controls.Add(this.tbSn);
            this.testProgram.Controls.Add(this.confirmSelectBtn);
            this.testProgram.Controls.Add(this.lblSn);
            this.testProgram.Controls.Add(this.lblSelectProgram);
            this.testProgram.Controls.Add(this.programList);
            this.testProgram.Enabled = false;
            this.testProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.testProgram.Location = new System.Drawing.Point(12, 11);
            this.testProgram.Name = "testProgram";
            this.testProgram.Size = new System.Drawing.Size(474, 117);
            this.testProgram.TabIndex = 9;
            this.testProgram.TabStop = false;
            this.testProgram.Text = "Test Program";
            // 
            // tbSn
            // 
            this.tbSn.AutoCompleteCustomSource.AddRange(new string[] {
            "292A01977RTA10780023",
            "220010002108260001"});
            this.tbSn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSn.Location = new System.Drawing.Point(164, 70);
            this.tbSn.MaxLength = 20;
            this.tbSn.Name = "tbSn";
            this.tbSn.Size = new System.Drawing.Size(197, 26);
            this.tbSn.TabIndex = 2;
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSn.Location = new System.Drawing.Point(73, 73);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(85, 20);
            this.lblSn.TabIndex = 1;
            this.lblSn.Text = "Serial No. :";
            // 
            // lblSelectProgram
            // 
            this.lblSelectProgram.AutoSize = true;
            this.lblSelectProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectProgram.Location = new System.Drawing.Point(22, 29);
            this.lblSelectProgram.Name = "lblSelectProgram";
            this.lblSelectProgram.Size = new System.Drawing.Size(136, 20);
            this.lblSelectProgram.TabIndex = 1;
            this.lblSelectProgram.Text = "Choose Program :";
            // 
            // programList
            // 
            this.programList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.programList.FormattingEnabled = true;
            this.programList.Items.AddRange(new object[] {
            "BMW\t- CCU",
            "DAIMLER\t- OBC",
            "DAIMLER\t- DC Box 1.2",
            "DAIMLER\t- DC Box 1.2H",
            "DAIMLER\t- DC Box 2.0",
            "RENAULT\t- 5DH",
            "NISSAN\t- OBC",
            "CUSTOM "});
            this.programList.Location = new System.Drawing.Point(164, 25);
            this.programList.Name = "programList";
            this.programList.Size = new System.Drawing.Size(197, 28);
            this.programList.TabIndex = 1;
            this.programList.SelectionChangeCommitted += new System.EventHandler(this.programList_SelectionChangeCommitted);
            // 
            // manualDC
            // 
            this.manualDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manualDC.Controls.Add(this.lblDMMPort);
            this.manualDC.Controls.Add(this.lblDCPort);
            this.manualDC.Controls.Add(this.lblShowCurrScr);
            this.manualDC.Controls.Add(this.lblPowScr);
            this.manualDC.Controls.Add(this.lblCurrScr);
            this.manualDC.Controls.Add(this.lblSetCurrScr);
            this.manualDC.Controls.Add(this.lblVoltScr);
            this.manualDC.Controls.Add(this.lblSetVoltScr);
            this.manualDC.Controls.Add(this.lblShowVoltScr);
            this.manualDC.Controls.Add(this.showPowScr);
            this.manualDC.Controls.Add(this.setCurrScr);
            this.manualDC.Controls.Add(this.showCurrScr);
            this.manualDC.Controls.Add(this.setVoltScr);
            this.manualDC.Controls.Add(this.showVoltScr);
            this.manualDC.Controls.Add(this.lblToggleOn);
            this.manualDC.Controls.Add(this.lblToggleOff);
            this.manualDC.Controls.Add(this.btnToggleOff);
            this.manualDC.Controls.Add(this.chroma);
            this.manualDC.Controls.Add(this.setPointManual);
            this.manualDC.Controls.Add(this.btnToggleOn);
            this.manualDC.Enabled = false;
            this.manualDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.manualDC.Location = new System.Drawing.Point(990, 134);
            this.manualDC.Name = "manualDC";
            this.manualDC.Size = new System.Drawing.Size(677, 218);
            this.manualDC.TabIndex = 8;
            this.manualDC.TabStop = false;
            this.manualDC.Text = "Manual - DC Source (Chroma 62100H Series)";
            this.manualDC.Visible = false;
            // 
            // lblDMMPort
            // 
            this.lblDMMPort.AutoSize = true;
            this.lblDMMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDMMPort.Location = new System.Drawing.Point(380, 18);
            this.lblDMMPort.Name = "lblDMMPort";
            this.lblDMMPort.Size = new System.Drawing.Size(47, 15);
            this.lblDMMPort.TabIndex = 6;
            this.lblDMMPort.Text = "PORT2";
            // 
            // lblDCPort
            // 
            this.lblDCPort.AutoSize = true;
            this.lblDCPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDCPort.Location = new System.Drawing.Point(380, 1);
            this.lblDCPort.Name = "lblDCPort";
            this.lblDCPort.Size = new System.Drawing.Size(47, 15);
            this.lblDCPort.TabIndex = 6;
            this.lblDCPort.Text = "PORT1";
            // 
            // lblShowCurrScr
            // 
            this.lblShowCurrScr.AutoSize = true;
            this.lblShowCurrScr.BackColor = System.Drawing.Color.Black;
            this.lblShowCurrScr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCurrScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblShowCurrScr.Location = new System.Drawing.Point(436, 96);
            this.lblShowCurrScr.Name = "lblShowCurrScr";
            this.lblShowCurrScr.Size = new System.Drawing.Size(22, 24);
            this.lblShowCurrScr.TabIndex = 0;
            this.lblShowCurrScr.Text = "A";
            // 
            // lblPowScr
            // 
            this.lblPowScr.AutoSize = true;
            this.lblPowScr.BackColor = System.Drawing.Color.Black;
            this.lblPowScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblPowScr.Location = new System.Drawing.Point(440, 121);
            this.lblPowScr.Name = "lblPowScr";
            this.lblPowScr.Size = new System.Drawing.Size(14, 15);
            this.lblPowScr.TabIndex = 0;
            this.lblPowScr.Text = "W";
            // 
            // lblCurrScr
            // 
            this.lblCurrScr.AutoSize = true;
            this.lblCurrScr.BackColor = System.Drawing.Color.Black;
            this.lblCurrScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblCurrScr.Location = new System.Drawing.Point(440, 69);
            this.lblCurrScr.Name = "lblCurrScr";
            this.lblCurrScr.Size = new System.Drawing.Size(14, 15);
            this.lblCurrScr.TabIndex = 0;
            this.lblCurrScr.Text = "A";
            // 
            // lblSetCurrScr
            // 
            this.lblSetCurrScr.AutoSize = true;
            this.lblSetCurrScr.BackColor = System.Drawing.Color.Black;
            this.lblSetCurrScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCurrScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblSetCurrScr.Location = new System.Drawing.Point(351, 69);
            this.lblSetCurrScr.Name = "lblSetCurrScr";
            this.lblSetCurrScr.Size = new System.Drawing.Size(28, 15);
            this.lblSetCurrScr.TabIndex = 0;
            this.lblSetCurrScr.Text = "I =";
            // 
            // lblVoltScr
            // 
            this.lblVoltScr.AutoSize = true;
            this.lblVoltScr.BackColor = System.Drawing.Color.Black;
            this.lblVoltScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblVoltScr.Location = new System.Drawing.Point(308, 69);
            this.lblVoltScr.Name = "lblVoltScr";
            this.lblVoltScr.Size = new System.Drawing.Size(14, 15);
            this.lblVoltScr.TabIndex = 0;
            this.lblVoltScr.Text = "V";
            // 
            // lblSetVoltScr
            // 
            this.lblSetVoltScr.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblSetVoltScr.AutoSize = true;
            this.lblSetVoltScr.BackColor = System.Drawing.Color.Black;
            this.lblSetVoltScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetVoltScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblSetVoltScr.Location = new System.Drawing.Point(219, 69);
            this.lblSetVoltScr.Name = "lblSetVoltScr";
            this.lblSetVoltScr.Size = new System.Drawing.Size(28, 15);
            this.lblSetVoltScr.TabIndex = 0;
            this.lblSetVoltScr.Text = "V =";
            // 
            // lblShowVoltScr
            // 
            this.lblShowVoltScr.AutoSize = true;
            this.lblShowVoltScr.BackColor = System.Drawing.Color.Black;
            this.lblShowVoltScr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowVoltScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lblShowVoltScr.Location = new System.Drawing.Point(304, 96);
            this.lblShowVoltScr.Name = "lblShowVoltScr";
            this.lblShowVoltScr.Size = new System.Drawing.Size(22, 24);
            this.lblShowVoltScr.TabIndex = 0;
            this.lblShowVoltScr.Text = "V";
            // 
            // showPowScr
            // 
            this.showPowScr.BackColor = System.Drawing.Color.Black;
            this.showPowScr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showPowScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.showPowScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPowScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.showPowScr.Location = new System.Drawing.Point(385, 121);
            this.showPowScr.Name = "showPowScr";
            this.showPowScr.ReadOnly = true;
            this.showPowScr.Size = new System.Drawing.Size(45, 16);
            this.showPowScr.TabIndex = 0;
            this.showPowScr.TabStop = false;
            this.showPowScr.Text = "0.0";
            this.showPowScr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // setCurrScr
            // 
            this.setCurrScr.BackColor = System.Drawing.Color.Black;
            this.setCurrScr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setCurrScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.setCurrScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCurrScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.setCurrScr.Location = new System.Drawing.Point(385, 69);
            this.setCurrScr.Name = "setCurrScr";
            this.setCurrScr.ReadOnly = true;
            this.setCurrScr.Size = new System.Drawing.Size(45, 16);
            this.setCurrScr.TabIndex = 0;
            this.setCurrScr.TabStop = false;
            this.setCurrScr.Text = "0.00";
            this.setCurrScr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // showCurrScr
            // 
            this.showCurrScr.BackColor = System.Drawing.Color.Black;
            this.showCurrScr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCurrScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.showCurrScr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCurrScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.showCurrScr.Location = new System.Drawing.Point(318, 96);
            this.showCurrScr.Name = "showCurrScr";
            this.showCurrScr.ReadOnly = true;
            this.showCurrScr.Size = new System.Drawing.Size(116, 25);
            this.showCurrScr.TabIndex = 0;
            this.showCurrScr.TabStop = false;
            this.showCurrScr.Text = "00.0000";
            this.showCurrScr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // setVoltScr
            // 
            this.setVoltScr.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.setVoltScr.BackColor = System.Drawing.Color.Black;
            this.setVoltScr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setVoltScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.setVoltScr.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setVoltScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.setVoltScr.Location = new System.Drawing.Point(253, 69);
            this.setVoltScr.Name = "setVoltScr";
            this.setVoltScr.ReadOnly = true;
            this.setVoltScr.Size = new System.Drawing.Size(45, 16);
            this.setVoltScr.TabIndex = 0;
            this.setVoltScr.TabStop = false;
            this.setVoltScr.Text = "0.00";
            this.setVoltScr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // showVoltScr
            // 
            this.showVoltScr.BackColor = System.Drawing.Color.Black;
            this.showVoltScr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showVoltScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.showVoltScr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVoltScr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.showVoltScr.Location = new System.Drawing.Point(203, 96);
            this.showVoltScr.Name = "showVoltScr";
            this.showVoltScr.ReadOnly = true;
            this.showVoltScr.Size = new System.Drawing.Size(101, 25);
            this.showVoltScr.TabIndex = 0;
            this.showVoltScr.TabStop = false;
            this.showVoltScr.Text = "00.0000";
            this.showVoltScr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblToggleOn
            // 
            this.lblToggleOn.AutoSize = true;
            this.lblToggleOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.lblToggleOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblToggleOn.ForeColor = System.Drawing.Color.Black;
            this.lblToggleOn.Location = new System.Drawing.Point(530, 408);
            this.lblToggleOn.Name = "lblToggleOn";
            this.lblToggleOn.Size = new System.Drawing.Size(30, 16);
            this.lblToggleOn.TabIndex = 5;
            this.lblToggleOn.Text = "ON";
            this.lblToggleOn.Visible = false;
            // 
            // lblToggleOff
            // 
            this.lblToggleOff.AutoSize = true;
            this.lblToggleOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.lblToggleOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblToggleOff.ForeColor = System.Drawing.Color.Black;
            this.lblToggleOff.Location = new System.Drawing.Point(582, 409);
            this.lblToggleOff.Name = "lblToggleOff";
            this.lblToggleOff.Size = new System.Drawing.Size(37, 16);
            this.lblToggleOff.TabIndex = 5;
            this.lblToggleOff.Text = "OFF";
            // 
            // setPointManual
            // 
            this.setPointManual.Controls.Add(this.currBoxManual);
            this.setPointManual.Controls.Add(this.voltBoxManual);
            this.setPointManual.Controls.Add(this.button1);
            this.setPointManual.Controls.Add(this.btnSetVoltManual);
            this.setPointManual.Controls.Add(this.lblCurrManual);
            this.setPointManual.Controls.Add(this.lblCurrManual2);
            this.setPointManual.Controls.Add(this.lblVoltManual2);
            this.setPointManual.Controls.Add(this.lblVoltManual);
            this.setPointManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.setPointManual.Location = new System.Drawing.Point(29, 354);
            this.setPointManual.Name = "setPointManual";
            this.setPointManual.Size = new System.Drawing.Size(474, 117);
            this.setPointManual.TabIndex = 3;
            this.setPointManual.TabStop = false;
            this.setPointManual.Text = "Setpoint";
            // 
            // currBoxManual
            // 
            this.currBoxManual.DecimalPlaces = 2;
            this.currBoxManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.currBoxManual.Increment = new decimal(new int[] {
            500,
            0,
            0,
            262144});
            this.currBoxManual.Location = new System.Drawing.Point(143, 74);
            this.currBoxManual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.currBoxManual.Name = "currBoxManual";
            this.currBoxManual.Size = new System.Drawing.Size(128, 26);
            this.currBoxManual.TabIndex = 2;
            this.currBoxManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currBoxManual.ThousandsSeparator = true;
            this.currBoxManual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currBoxManual_KeyDown);
            // 
            // voltBoxManual
            // 
            this.voltBoxManual.DecimalPlaces = 2;
            this.voltBoxManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.voltBoxManual.Increment = new decimal(new int[] {
            500,
            0,
            0,
            262144});
            this.voltBoxManual.Location = new System.Drawing.Point(143, 29);
            this.voltBoxManual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.voltBoxManual.Name = "voltBoxManual";
            this.voltBoxManual.Size = new System.Drawing.Size(128, 26);
            this.voltBoxManual.TabIndex = 1;
            this.voltBoxManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.voltBoxManual.ThousandsSeparator = true;
            this.voltBoxManual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voltBoxManual_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(325, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetCurrManual_Click);
            // 
            // btnSetVoltManual
            // 
            this.btnSetVoltManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetVoltManual.Location = new System.Drawing.Point(325, 25);
            this.btnSetVoltManual.Name = "btnSetVoltManual";
            this.btnSetVoltManual.Size = new System.Drawing.Size(118, 32);
            this.btnSetVoltManual.TabIndex = 1;
            this.btnSetVoltManual.TabStop = false;
            this.btnSetVoltManual.Text = "Set";
            this.btnSetVoltManual.UseVisualStyleBackColor = true;
            this.btnSetVoltManual.Click += new System.EventHandler(this.btnSetVoltManual_Click);
            // 
            // lblCurrManual
            // 
            this.lblCurrManual.AutoSize = true;
            this.lblCurrManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrManual.Location = new System.Drawing.Point(67, 76);
            this.lblCurrManual.Name = "lblCurrManual";
            this.lblCurrManual.Size = new System.Drawing.Size(70, 20);
            this.lblCurrManual.TabIndex = 0;
            this.lblCurrManual.Text = "Current :";
            // 
            // lblCurrManual2
            // 
            this.lblCurrManual2.AutoSize = true;
            this.lblCurrManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrManual2.Location = new System.Drawing.Point(287, 76);
            this.lblCurrManual2.Name = "lblCurrManual2";
            this.lblCurrManual2.Size = new System.Drawing.Size(20, 20);
            this.lblCurrManual2.TabIndex = 0;
            this.lblCurrManual2.Text = "A";
            // 
            // lblVoltManual2
            // 
            this.lblVoltManual2.AutoSize = true;
            this.lblVoltManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVoltManual2.Location = new System.Drawing.Point(287, 31);
            this.lblVoltManual2.Name = "lblVoltManual2";
            this.lblVoltManual2.Size = new System.Drawing.Size(20, 20);
            this.lblVoltManual2.TabIndex = 0;
            this.lblVoltManual2.Text = "V";
            // 
            // lblVoltManual
            // 
            this.lblVoltManual.AutoSize = true;
            this.lblVoltManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVoltManual.Location = new System.Drawing.Point(65, 31);
            this.lblVoltManual.Name = "lblVoltManual";
            this.lblVoltManual.Size = new System.Drawing.Size(72, 20);
            this.lblVoltManual.TabIndex = 0;
            this.lblVoltManual.Text = "Voltage :";
            // 
            // editSpecTest
            // 
            this.editSpecTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editSpecTest.Controls.Add(this.cleatBtn);
            this.editSpecTest.Controls.Add(this.insertBtn);
            this.editSpecTest.Controls.Add(this.gridTable2);
            this.editSpecTest.Enabled = false;
            this.editSpecTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.editSpecTest.Location = new System.Drawing.Point(990, 358);
            this.editSpecTest.Name = "editSpecTest";
            this.editSpecTest.Size = new System.Drawing.Size(677, 272);
            this.editSpecTest.TabIndex = 8;
            this.editSpecTest.TabStop = false;
            this.editSpecTest.Text = "Edit Specification Test";
            this.editSpecTest.Visible = false;
            // 
            // cleatBtn
            // 
            this.cleatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cleatBtn.BackColor = System.Drawing.Color.Red;
            this.cleatBtn.Location = new System.Drawing.Point(538, 202);
            this.cleatBtn.Name = "cleatBtn";
            this.cleatBtn.Size = new System.Drawing.Size(121, 64);
            this.cleatBtn.TabIndex = 2;
            this.cleatBtn.TabStop = false;
            this.cleatBtn.Text = "Clear";
            this.cleatBtn.UseVisualStyleBackColor = false;
            this.cleatBtn.Click += new System.EventHandler(this.cleatBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.insertBtn.Location = new System.Drawing.Point(538, 29);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(121, 64);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // gridTable2
            // 
            this.gridTable2.AllowUserToOrderColumns = true;
            this.gridTable2.AllowUserToResizeRows = false;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle69;
            this.gridTable2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTable2.BackgroundColor = System.Drawing.Color.White;
            this.gridTable2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTable2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridTable2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
            this.gridTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editContactPairs,
            this.editMaxRes});
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.DefaultCellStyle = dataGridViewCellStyle73;
            this.gridTable2.Location = new System.Drawing.Point(16, 29);
            this.gridTable2.Name = "gridTable2";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.RowHeadersDefaultCellStyle = dataGridViewCellStyle74;
            this.gridTable2.RowHeadersVisible = false;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.RowsDefaultCellStyle = dataGridViewCellStyle75;
            this.gridTable2.Size = new System.Drawing.Size(510, 237);
            this.gridTable2.TabIndex = 7;
            // 
            // editContactPairs
            // 
            this.editContactPairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editContactPairs.DefaultCellStyle = dataGridViewCellStyle71;
            this.editContactPairs.HeaderText = "Contact Pairs";
            this.editContactPairs.Name = "editContactPairs";
            // 
            // editMaxRes
            // 
            this.editMaxRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle72.Format = "N1";
            dataGridViewCellStyle72.NullValue = null;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editMaxRes.DefaultCellStyle = dataGridViewCellStyle72;
            this.editMaxRes.HeaderText = "Max.Res (mΩ)";
            this.editMaxRes.Name = "editMaxRes";
            this.editMaxRes.Width = 150;
            // 
            // testData
            // 
            this.testData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.testData.Controls.Add(this.btnClearData);
            this.testData.Controls.Add(this.gridTable1);
            this.testData.Enabled = false;
            this.testData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.testData.Location = new System.Drawing.Point(12, 358);
            this.testData.Name = "testData";
            this.testData.Size = new System.Drawing.Size(958, 272);
            this.testData.TabIndex = 8;
            this.testData.TabStop = false;
            this.testData.Text = "Test Data";
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearData.ForeColor = System.Drawing.Color.Red;
            this.btnClearData.Location = new System.Drawing.Point(876, 209);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(76, 57);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear lastest Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // gridTable1
            // 
            this.gridTable1.AllowUserToOrderColumns = true;
            this.gridTable1.AllowUserToResizeRows = false;
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle76;
            this.gridTable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTable1.BackgroundColor = System.Drawing.Color.White;
            this.gridTable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTable1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle77;
            this.gridTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactPairs,
            this.maxRes,
            this.measVolt,
            this.res,
            this.result});
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle83.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle83.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle83.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.DefaultCellStyle = dataGridViewCellStyle83;
            this.gridTable1.Location = new System.Drawing.Point(16, 29);
            this.gridTable1.Name = "gridTable1";
            this.gridTable1.ReadOnly = true;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle84.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle84.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle84.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle84;
            this.gridTable1.RowHeadersVisible = false;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle85.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle85.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.RowsDefaultCellStyle = dataGridViewCellStyle85;
            this.gridTable1.Size = new System.Drawing.Size(854, 237);
            this.gridTable1.TabIndex = 5;
            // 
            // contactPairs
            // 
            this.contactPairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactPairs.DefaultCellStyle = dataGridViewCellStyle78;
            this.contactPairs.HeaderText = "Contact Pairs";
            this.contactPairs.Name = "contactPairs";
            this.contactPairs.ReadOnly = true;
            // 
            // maxRes
            // 
            this.maxRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle79.Format = "N1";
            dataGridViewCellStyle79.NullValue = null;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maxRes.DefaultCellStyle = dataGridViewCellStyle79;
            this.maxRes.HeaderText = "Max.Res (mΩ)";
            this.maxRes.Name = "maxRes";
            this.maxRes.ReadOnly = true;
            // 
            // measVolt
            // 
            this.measVolt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle80.Format = "N2";
            dataGridViewCellStyle80.NullValue = null;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.measVolt.DefaultCellStyle = dataGridViewCellStyle80;
            this.measVolt.HeaderText = "Voltage (mV)";
            this.measVolt.Name = "measVolt";
            this.measVolt.ReadOnly = true;
            // 
            // res
            // 
            this.res.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle81.Format = "N2";
            dataGridViewCellStyle81.NullValue = null;
            this.res.DefaultCellStyle = dataGridViewCellStyle81;
            this.res.HeaderText = "Res (mΩ)";
            this.res.Name = "res";
            this.res.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle82.NullValue = null;
            dataGridViewCellStyle82.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.result.DefaultCellStyle = dataGridViewCellStyle82;
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // saveData
            // 
            this.saveData.CheckPathExists = false;
            this.saveData.DefaultExt = "csv";
            this.saveData.FileName = "PE_data";
            this.saveData.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            this.saveData.RestoreDirectory = true;
            this.saveData.ShowHelp = true;
            this.saveData.Title = "Export Data";
            // 
            // openFile
            // 
            this.openFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx|CSV (Comma Delimited) (*.csv)|*.csv|Text files (*." +
    "txt)|*.txt|All files (*.*)|*.*";
            // 
            // comPort2
            // 
            this.comPort2.BaudRate = 115200;
            this.comPort2.DtrEnable = true;
            this.comPort2.PortName = "COM2";
            this.comPort2.RtsEnable = true;
            this.comPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived_2);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel.Text = "STATUS";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(983, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // delta
            // 
            this.delta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.delta.ErrorImage = global::PE.Properties.Resources.delta;
            this.delta.Image = global::PE.Properties.Resources.delta;
            this.delta.InitialImage = global::PE.Properties.Resources.delta;
            this.delta.Location = new System.Drawing.Point(789, 32);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(179, 56);
            this.delta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delta.TabIndex = 9;
            this.delta.TabStop = false;
            // 
            // disConnect
            // 
            this.disConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.disConnect.ErrorImage = global::PE.Properties.Resources.icons8_disconnected_64;
            this.disConnect.Image = global::PE.Properties.Resources.icons8_disconnected_64;
            this.disConnect.InitialImage = global::PE.Properties.Resources.icons8_disconnected_64;
            this.disConnect.Location = new System.Drawing.Point(716, 27);
            this.disConnect.Name = "disConnect";
            this.disConnect.Size = new System.Drawing.Size(67, 67);
            this.disConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disConnect.TabIndex = 7;
            this.disConnect.TabStop = false;
            // 
            // connect
            // 
            this.connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.connect.ErrorImage = global::PE.Properties.Resources.icons8_connected_64;
            this.connect.Image = global::PE.Properties.Resources.icons8_connected_64;
            this.connect.InitialImage = global::PE.Properties.Resources.icons8_connected_64;
            this.connect.Location = new System.Drawing.Point(716, 27);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(67, 67);
            this.connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.connect.TabIndex = 7;
            this.connect.TabStop = false;
            this.connect.Visible = false;
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Red;
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusBox.Location = new System.Drawing.Point(286, 0);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(30, 15);
            this.statusBox.TabIndex = 3;
            this.statusBox.TabStop = false;
            // 
            // confirmSelectBtn
            // 
            this.confirmSelectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confirmSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.confirmSelectBtn.Image = global::PE.Properties.Resources.icons8_ok_64;
            this.confirmSelectBtn.Location = new System.Drawing.Point(375, 25);
            this.confirmSelectBtn.Name = "confirmSelectBtn";
            this.confirmSelectBtn.Size = new System.Drawing.Size(86, 71);
            this.confirmSelectBtn.TabIndex = 2;
            this.confirmSelectBtn.TabStop = false;
            this.confirmSelectBtn.UseVisualStyleBackColor = false;
            this.confirmSelectBtn.Click += new System.EventHandler(this.confirmSelectBtn_Click);
            // 
            // btnToggleOff
            // 
            this.btnToggleOff.ErrorImage = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.Image = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.InitialImage = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.Location = new System.Drawing.Point(520, 379);
            this.btnToggleOff.Name = "btnToggleOff";
            this.btnToggleOff.Size = new System.Drawing.Size(106, 77);
            this.btnToggleOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleOff.TabIndex = 4;
            this.btnToggleOff.TabStop = false;
            this.btnToggleOff.Click += new System.EventHandler(this.btnToggleOff_Click);
            // 
            // chroma
            // 
            this.chroma.Image = global::PE.Properties.Resources.CHR_62000H;
            this.chroma.Location = new System.Drawing.Point(31, 37);
            this.chroma.Name = "chroma";
            this.chroma.Size = new System.Drawing.Size(893, 294);
            this.chroma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chroma.TabIndex = 0;
            this.chroma.TabStop = false;
            // 
            // btnToggleOn
            // 
            this.btnToggleOn.ErrorImage = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.Image = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.InitialImage = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.Location = new System.Drawing.Point(520, 379);
            this.btnToggleOn.Name = "btnToggleOn";
            this.btnToggleOn.Size = new System.Drawing.Size(106, 77);
            this.btnToggleOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleOn.TabIndex = 4;
            this.btnToggleOn.TabStop = false;
            this.btnToggleOn.Visible = false;
            this.btnToggleOn.Click += new System.EventHandler(this.btnToggleOn_Click);
            // 
            // warning
            // 
            this.warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.warning.ErrorImage = global::PE.Properties.Resources.icons8_electricity_hazard_64;
            this.warning.Image = global::PE.Properties.Resources.icons8_electricity_hazard_64;
            this.warning.InitialImage = global::PE.Properties.Resources.icons8_electricity_hazard_64;
            this.warning.Location = new System.Drawing.Point(367, 17);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(40, 36);
            this.warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warning.TabIndex = 9;
            this.warning.TabStop = false;
            this.warning.Visible = false;
            // 
            // dangerOn
            // 
            this.dangerOn.ErrorImage = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.Image = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.InitialImage = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.Location = new System.Drawing.Point(11, 64);
            this.dangerOn.Name = "dangerOn";
            this.dangerOn.Size = new System.Drawing.Size(450, 148);
            this.dangerOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dangerOn.TabIndex = 4;
            this.dangerOn.TabStop = false;
            this.dangerOn.Visible = false;
            // 
            // danger
            // 
            this.danger.ErrorImage = global::PE.Properties.Resources.Artboard_56G;
            this.danger.Image = global::PE.Properties.Resources.Artboard_56G;
            this.danger.InitialImage = global::PE.Properties.Resources.Artboard_56G;
            this.danger.Location = new System.Drawing.Point(11, 64);
            this.danger.Name = "danger";
            this.danger.Size = new System.Drawing.Size(450, 148);
            this.danger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger.TabIndex = 4;
            this.danger.TabStop = false;
            // 
            // dmm34401a
            // 
            this.dmm34401a.Enabled = false;
            this.dmm34401a.ErrorImage = global::PE.Properties.Resources._34401DMM;
            this.dmm34401a.Image = global::PE.Properties.Resources._34401DMM;
            this.dmm34401a.InitialImage = global::PE.Properties.Resources._34401DMM;
            this.dmm34401a.Location = new System.Drawing.Point(145, 26);
            this.dmm34401a.Name = "dmm34401a";
            this.dmm34401a.Size = new System.Drawing.Size(200, 92);
            this.dmm34401a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dmm34401a.TabIndex = 4;
            this.dmm34401a.TabStop = false;
            // 
            // startTool
            // 
            this.startTool.Image = global::PE.Properties.Resources.icons8_conflict_48;
            this.startTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.startTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startTool.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.startTool.Name = "startTool";
            this.startTool.Size = new System.Drawing.Size(52, 67);
            this.startTool.Text = "Start";
            this.startTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startTool.Click += new System.EventHandler(this.startTool_Click);
            // 
            // homeTool
            // 
            this.homeTool.Image = global::PE.Properties.Resources.icons8_home_48;
            this.homeTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeTool.Name = "homeTool";
            this.homeTool.Size = new System.Drawing.Size(52, 67);
            this.homeTool.Text = "Home";
            this.homeTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeTool.ToolTipText = "Home";
            this.homeTool.Click += new System.EventHandler(this.homeTool_Click);
            // 
            // editTool
            // 
            this.editTool.Image = global::PE.Properties.Resources.icons8_edit_48;
            this.editTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(80, 67);
            this.editTool.Text = "Edit Program";
            this.editTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // manualTool
            // 
            this.manualTool.Image = global::PE.Properties.Resources.icons8_manual_48;
            this.manualTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manualTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manualTool.Name = "manualTool";
            this.manualTool.Size = new System.Drawing.Size(52, 67);
            this.manualTool.Text = "Manual";
            this.manualTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manualTool.ToolTipText = "Manual DC-source";
            this.manualTool.Click += new System.EventHandler(this.manualTool_Click);
            // 
            // databaseTool
            // 
            this.databaseTool.Image = global::PE.Properties.Resources.icons8_database_administrator_48;
            this.databaseTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.databaseTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.databaseTool.Name = "databaseTool";
            this.databaseTool.Size = new System.Drawing.Size(59, 67);
            this.databaseTool.Text = "Database";
            this.databaseTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.databaseTool.ToolTipText = "Connection\r\n setting";
            this.databaseTool.Click += new System.EventHandler(this.databaseTool_Click);
            // 
            // exportTool
            // 
            this.exportTool.Enabled = false;
            this.exportTool.Image = global::PE.Properties.Resources.icons8_microsoft_excel_2019_48;
            this.exportTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportTool.Name = "exportTool";
            this.exportTool.Size = new System.Drawing.Size(72, 67);
            this.exportTool.Text = "Export Data";
            this.exportTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exportTool.ToolTipText = "Export data";
            this.exportTool.Click += new System.EventHandler(this.exportTool_Click);
            // 
            // shutdownTool
            // 
            this.shutdownTool.Image = global::PE.Properties.Resources.icons8_shutdown_48;
            this.shutdownTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shutdownTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shutdownTool.Name = "shutdownTool";
            this.shutdownTool.Size = new System.Drawing.Size(52, 67);
            this.shutdownTool.Text = "Exit";
            this.shutdownTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shutdownTool.ToolTipText = "Exit Program";
            this.shutdownTool.Click += new System.EventHandler(this.shutdownTool_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Image = global::PE.Properties.Resources.icons8_open_folder_in_new_tab_32;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(163, 22);
            this.fileOpen.Text = "Open...";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Enabled = false;
            this.fileSave.Image = global::PE.Properties.Resources.icons8_save_32;
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(163, 22);
            this.fileSave.Text = "Save...";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Enabled = false;
            this.fileSaveAs.Image = global::PE.Properties.Resources.icons8_save_as_32;
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveAs.Size = new System.Drawing.Size(163, 22);
            this.fileSaveAs.Text = "Save As...";
            this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // fileExit
            // 
            this.fileExit.Image = global::PE.Properties.Resources.icons8_shutdown_32;
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.fileExit.Size = new System.Drawing.Size(163, 22);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // configPort
            // 
            this.configPort.Image = global::PE.Properties.Resources.icons8_internet_of_things_32;
            this.configPort.Name = "configPort";
            this.configPort.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.configPort.Size = new System.Drawing.Size(186, 22);
            this.configPort.Text = "Port";
            this.configPort.Click += new System.EventHandler(this.configPort_Click);
            // 
            // configEdit
            // 
            this.configEdit.Image = global::PE.Properties.Resources.icons8_edit_32;
            this.configEdit.Name = "configEdit";
            this.configEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.configEdit.Size = new System.Drawing.Size(186, 22);
            this.configEdit.Text = "Edit program";
            this.configEdit.Click += new System.EventHandler(this.configEdit_Click);
            // 
            // configManual
            // 
            this.configManual.Image = global::PE.Properties.Resources.icons8_manual_32;
            this.configManual.Name = "configManual";
            this.configManual.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.configManual.Size = new System.Drawing.Size(186, 22);
            this.configManual.Text = "Manual";
            this.configManual.Click += new System.EventHandler(this.configManual_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::PE.Properties.Resources.icons8_database_administrator_32;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // helpInfo
            // 
            this.helpInfo.Image = global::PE.Properties.Resources.icons8_about_32;
            this.helpInfo.Name = "helpInfo";
            this.helpInfo.Size = new System.Drawing.Size(163, 22);
            this.helpInfo.Text = "About PE Testing";
            // 
            // helpHelp
            // 
            this.helpHelp.Image = global::PE.Properties.Resources.icons8_get_help_32;
            this.helpHelp.Name = "helpHelp";
            this.helpHelp.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.helpHelp.Size = new System.Drawing.Size(163, 22);
            this.helpHelp.Text = "Help";
            // 
            // peTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 749);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.disConnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.groupTest);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "peTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE TESTING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.serialPort.ResumeLayout(false);
            this.serialPort.PerformLayout();
            this.setPoint.ResumeLayout(false);
            this.setPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBox)).EndInit();
            this.startTesting.ResumeLayout(false);
            this.startTesting.PerformLayout();
            this.getData.ResumeLayout(false);
            this.getData.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupTest.ResumeLayout(false);
            this.testProgram.ResumeLayout(false);
            this.testProgram.PerformLayout();
            this.manualDC.ResumeLayout(false);
            this.manualDC.PerformLayout();
            this.setPointManual.ResumeLayout(false);
            this.setPointManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBoxManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBoxManual)).EndInit();
            this.editSpecTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable2)).EndInit();
            this.testData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chroma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangerOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmm34401a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem helpInfo;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox statusBox;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnScan;
        protected System.Windows.Forms.ComboBox cbbBaud;
        protected System.Windows.Forms.ComboBox cbbPort;
        public System.Windows.Forms.GroupBox serialPort;
        private System.Windows.Forms.RichTextBox rtbIncoming1;
        public System.Windows.Forms.NotifyIcon notifySerial;
        private System.Windows.Forms.GroupBox setPoint;
        private System.Windows.Forms.Label lblCurr;
        private System.Windows.Forms.Label lblCurr2;
        private System.Windows.Forms.Label lblVolt2;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.Button btnSetCurr;
        private System.Windows.Forms.Button btnSetVolt;
        public System.Windows.Forms.NumericUpDown voltBox;
        public System.Windows.Forms.NumericUpDown currBox;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem configPort;
        private System.Windows.Forms.PictureBox dangerOn;
        private System.Windows.Forms.PictureBox danger;
        public System.Windows.Forms.Timer dangerTime;
        private System.Windows.Forms.Label pushStart;
        private System.Windows.Forms.GroupBox startTesting;
        public System.IO.Ports.SerialPort comPort1;
        private System.Windows.Forms.GroupBox getData;
        private System.Windows.Forms.Label lblVolt3;
        public System.Windows.Forms.Label value;
        private System.Windows.Forms.PictureBox disConnect;
        private System.Windows.Forms.PictureBox connect;
        private System.Windows.Forms.GroupBox groupTest;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblTestResult;
        public System.Windows.Forms.ToolStripButton databaseTool;
        public System.Windows.Forms.ToolStripButton homeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpHelp;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        public System.Windows.Forms.DataGridView gridTable1;
        private System.Windows.Forms.GroupBox testData;
        public System.Windows.Forms.SaveFileDialog saveData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox delta;
        private System.Windows.Forms.PictureBox warning;
        private System.Windows.Forms.ToolStripMenuItem configEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox testProgram;
        internal System.Windows.Forms.ComboBox programList;
        private System.Windows.Forms.Button confirmSelectBtn;
        private System.Windows.Forms.Label lblSelectProgram;
        private System.Windows.Forms.RichTextBox rtbIncoming2;
        private System.Windows.Forms.Label lblSn;
        public System.Windows.Forms.TextBox tbSn;
        private System.Windows.Forms.GroupBox editSpecTest;
        public System.Windows.Forms.DataGridView gridTable2;
        private System.Windows.Forms.Button cleatBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn measVolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn editContactPairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn editMaxRes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton manualTool;
        public System.Windows.Forms.ToolStripButton shutdownTool;
        public System.Windows.Forms.ToolStripButton exportTool;
        public System.Windows.Forms.ToolStripButton editTool;
        private System.Windows.Forms.GroupBox manualDC;
        private System.Windows.Forms.PictureBox chroma;
        private System.Windows.Forms.GroupBox setPointManual;
        public System.Windows.Forms.NumericUpDown currBoxManual;
        public System.Windows.Forms.NumericUpDown voltBoxManual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetVoltManual;
        private System.Windows.Forms.Label lblCurrManual;
        private System.Windows.Forms.Label lblCurrManual2;
        private System.Windows.Forms.Label lblVoltManual2;
        private System.Windows.Forms.Label lblVoltManual;
        private System.Windows.Forms.PictureBox btnToggleOff;
        private System.Windows.Forms.PictureBox btnToggleOn;
        private System.Windows.Forms.Label lblToggleOff;
        private System.Windows.Forms.Label lblToggleOn;
        public System.Windows.Forms.Label lblShowCurrScr;
        public System.Windows.Forms.Label lblShowVoltScr;
        public System.Windows.Forms.TextBox showCurrScr;
        public System.Windows.Forms.TextBox showVoltScr;
        public System.Windows.Forms.TextBox setVoltScr;
        public System.Windows.Forms.Label lblCurrScr;
        public System.Windows.Forms.Label lblSetCurrScr;
        public System.Windows.Forms.Label lblVoltScr;
        public System.Windows.Forms.Label lblSetVoltScr;
        public System.Windows.Forms.TextBox setCurrScr;
        public System.Windows.Forms.Label lblPowScr;
        public System.Windows.Forms.TextBox showPowScr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem configManual;
        public System.Windows.Forms.ToolStripButton startTool;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnClearData;
        public System.IO.Ports.SerialPort comPort2;
        public System.Windows.Forms.Label lblDMMPort;
        public System.Windows.Forms.Label lblDCPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox dmm34401a;
    }
}

