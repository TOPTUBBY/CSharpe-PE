
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPEMan = new System.Windows.Forms.ToolStripMenuItem();
            this.helpInfo = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnCalDC = new System.Windows.Forms.Button();
            this.comPort1 = new System.IO.Ports.SerialPort(this.components);
            this.getData = new System.Windows.Forms.GroupBox();
            this.btnCalDMM = new System.Windows.Forms.Button();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.lblVolt3 = new System.Windows.Forms.Label();
            this.btnClearDMM = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.manualDC = new System.Windows.Forms.GroupBox();
            this.gbDMM = new System.Windows.Forms.GroupBox();
            this.statusDMM = new System.Windows.Forms.GroupBox();
            this.tbCommandDMM = new System.Windows.Forms.TextBox();
            this.lblDMMPort = new System.Windows.Forms.Label();
            this.tbIdentDMM = new System.Windows.Forms.TextBox();
            this.btnRemoteDMM = new System.Windows.Forms.Button();
            this.valueDMM = new System.Windows.Forms.Label();
            this.btnStopMeasure = new System.Windows.Forms.Button();
            this.btnStartMeasure = new System.Windows.Forms.Button();
            this.lblVoltDMM = new System.Windows.Forms.Label();
            this.gbDC = new System.Windows.Forms.GroupBox();
            this.lblToggleOn = new System.Windows.Forms.Label();
            this.lblToggleOff = new System.Windows.Forms.Label();
            this.statusDC = new System.Windows.Forms.GroupBox();
            this.tbCommandDC = new System.Windows.Forms.TextBox();
            this.tbIdentDC = new System.Windows.Forms.TextBox();
            this.lblDCPort = new System.Windows.Forms.Label();
            this.btnRemoteDC = new System.Windows.Forms.Button();
            this.btnClearDC = new System.Windows.Forms.Button();
            this.setPointManual = new System.Windows.Forms.GroupBox();
            this.currBoxManual = new System.Windows.Forms.NumericUpDown();
            this.voltBoxManual = new System.Windows.Forms.NumericUpDown();
            this.btnSetCurrManual = new System.Windows.Forms.Button();
            this.btnSetVoltManual = new System.Windows.Forms.Button();
            this.lblCurrManual = new System.Windows.Forms.Label();
            this.lblCurrManual2 = new System.Windows.Forms.Label();
            this.lblVoltManual2 = new System.Windows.Forms.Label();
            this.lblVoltManual = new System.Windows.Forms.Label();
            this.testProgram = new System.Windows.Forms.GroupBox();
            this.tbSn = new System.Windows.Forms.TextBox();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblSelectProgram = new System.Windows.Forms.Label();
            this.programList = new System.Windows.Forms.ComboBox();
            this.editSpecTest = new System.Windows.Forms.GroupBox();
            this.delProgBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
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
            this.ss = new System.Windows.Forms.StatusStrip();
            this.delta = new System.Windows.Forms.PictureBox();
            this.disConnect = new System.Windows.Forms.PictureBox();
            this.connect = new System.Windows.Forms.PictureBox();
            this.pbDMM = new System.Windows.Forms.PictureBox();
            this.btnToggleOff = new System.Windows.Forms.PictureBox();
            this.btnToggleOn = new System.Windows.Forms.PictureBox();
            this.pbDC = new System.Windows.Forms.PictureBox();
            this.pbDMMSign = new System.Windows.Forms.PictureBox();
            this.pbDCSign = new System.Windows.Forms.PictureBox();
            this.statusBox = new System.Windows.Forms.PictureBox();
            this.confirmSelectBtn = new System.Windows.Forms.Button();
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
            this.configManualDC = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpec = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpecBMW = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpecOBC = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpecDCB = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpecREN = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpecNIS = new System.Windows.Forms.ToolStripMenuItem();
            this.helpEqMan = new System.Windows.Forms.ToolStripMenuItem();
            this.helpEqManDC = new System.Windows.Forms.ToolStripMenuItem();
            this.helpEqManDMM = new System.Windows.Forms.ToolStripMenuItem();
            this.ms.SuspendLayout();
            this.serialPort.SuspendLayout();
            this.setPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBox)).BeginInit();
            this.startTesting.SuspendLayout();
            this.getData.SuspendLayout();
            this.ts.SuspendLayout();
            this.groupTest.SuspendLayout();
            this.manualDC.SuspendLayout();
            this.gbDMM.SuspendLayout();
            this.statusDMM.SuspendLayout();
            this.gbDC.SuspendLayout();
            this.statusDC.SuspendLayout();
            this.setPointManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBoxManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBoxManual)).BeginInit();
            this.testProgram.SuspendLayout();
            this.editSpecTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable2)).BeginInit();
            this.testData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable1)).BeginInit();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMMSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDCSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangerOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmm34401a)).BeginInit();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.White;
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.configToolStripMenu,
            this.helpToolStripMenu});
            this.ms.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(983, 24);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
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
            this.configManualDC,
            this.databaseToolStripMenuItem});
            this.configToolStripMenu.Name = "configToolStripMenu";
            this.configToolStripMenu.Size = new System.Drawing.Size(93, 20);
            this.configToolStripMenu.Text = "Configuration";
            // 
            // helpToolStripMenu
            // 
            this.helpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpSpec,
            this.helpEqMan,
            this.helpPEMan,
            this.helpInfo});
            this.helpToolStripMenu.Name = "helpToolStripMenu";
            this.helpToolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenu.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenu.Text = "Help";
            // 
            // helpPEMan
            // 
            this.helpPEMan.Image = global::PE.Properties.Resources.icons8_work_instructions_32;
            this.helpPEMan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpPEMan.Name = "helpPEMan";
            this.helpPEMan.Size = new System.Drawing.Size(260, 38);
            this.helpPEMan.Text = "PE Testing manual";
            this.helpPEMan.Click += new System.EventHandler(this.helpPEMan_Click);
            // 
            // helpInfo
            // 
            this.helpInfo.Name = "helpInfo";
            this.helpInfo.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.helpInfo.Size = new System.Drawing.Size(260, 38);
            this.helpInfo.Text = "About PE semi-auto testing";
            this.helpInfo.Click += new System.EventHandler(this.helpInfo_Click);
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
            this.currBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.currBox_MouseClick);
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
            this.voltBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.voltBox_MouseClick);
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
            this.dangerTime.Interval = 650;
            this.dangerTime.Tick += new System.EventHandler(this.dangerTime_Tick);
            // 
            // pushStart
            // 
            this.pushStart.AutoSize = true;
            this.pushStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushStart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pushStart.Location = new System.Drawing.Point(72, 29);
            this.pushStart.Name = "pushStart";
            this.pushStart.Size = new System.Drawing.Size(297, 25);
            this.pushStart.TabIndex = 5;
            this.pushStart.Text = "Push foot button to Start ...";
            this.pushStart.Visible = false;
            // 
            // startTesting
            // 
            this.startTesting.Controls.Add(this.btnCalDC);
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
            this.startTesting.Text = "Start testing (DC-Source Chroma 62000H )";
            // 
            // btnCalDC
            // 
            this.btnCalDC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCalDC.Location = new System.Drawing.Point(393, 0);
            this.btnCalDC.Name = "btnCalDC";
            this.btnCalDC.Size = new System.Drawing.Size(75, 26);
            this.btnCalDC.TabIndex = 6;
            this.btnCalDC.TabStop = false;
            this.btnCalDC.Text = "Calibration";
            this.btnCalDC.UseVisualStyleBackColor = true;
            this.btnCalDC.Click += new System.EventHandler(this.btnCalDC_Click);
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
            this.getData.Controls.Add(this.btnCalDMM);
            this.getData.Controls.Add(this.lblTestResult);
            this.getData.Controls.Add(this.dmm34401a);
            this.getData.Controls.Add(this.lblVolt3);
            this.getData.Controls.Add(this.btnClearDMM);
            this.getData.Controls.Add(this.value);
            this.getData.Enabled = false;
            this.getData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getData.Location = new System.Drawing.Point(496, 134);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(474, 218);
            this.getData.TabIndex = 6;
            this.getData.TabStop = false;
            this.getData.Text = "Get data (DMM - Keysight 34401a)";
            // 
            // btnCalDMM
            // 
            this.btnCalDMM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCalDMM.Location = new System.Drawing.Point(392, 0);
            this.btnCalDMM.Name = "btnCalDMM";
            this.btnCalDMM.Size = new System.Drawing.Size(75, 26);
            this.btnCalDMM.TabIndex = 6;
            this.btnCalDMM.TabStop = false;
            this.btnCalDMM.Text = "Calibration";
            this.btnCalDMM.UseVisualStyleBackColor = true;
            this.btnCalDMM.Click += new System.EventHandler(this.btnCalDMM_Click);
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
            // btnClearDMM
            // 
            this.btnClearDMM.BackColor = System.Drawing.Color.Red;
            this.btnClearDMM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearDMM.ForeColor = System.Drawing.Color.White;
            this.btnClearDMM.Location = new System.Drawing.Point(345, 73);
            this.btnClearDMM.Name = "btnClearDMM";
            this.btnClearDMM.Size = new System.Drawing.Size(117, 32);
            this.btnClearDMM.TabIndex = 1;
            this.btnClearDMM.TabStop = false;
            this.btnClearDMM.Text = "Clear Error";
            this.btnClearDMM.UseVisualStyleBackColor = false;
            this.btnClearDMM.Click += new System.EventHandler(this.btnClearDMM_Click);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.BackColor = System.Drawing.Color.Black;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.value.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.value.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.Color.Cyan;
            this.value.Location = new System.Drawing.Point(48, 124);
            this.value.MaximumSize = new System.Drawing.Size(275, 75);
            this.value.MinimumSize = new System.Drawing.Size(275, 75);
            this.value.Name = "value";
            this.value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.value.Size = new System.Drawing.Size(275, 75);
            this.value.TabIndex = 6;
            this.value.Text = "---.---";
            this.value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.value.UseCompatibleTextRendering = true;
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ts.Location = new System.Drawing.Point(0, 24);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(983, 70);
            this.ts.Stretch = true;
            this.ts.TabIndex = 8;
            this.ts.Text = "toolStrip1";
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
            this.groupTest.Controls.Add(this.manualDC);
            this.groupTest.Controls.Add(this.serialPort);
            this.groupTest.Controls.Add(this.testProgram);
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
            // manualDC
            // 
            this.manualDC.Controls.Add(this.gbDMM);
            this.manualDC.Controls.Add(this.gbDC);
            this.manualDC.Controls.Add(this.pbDMMSign);
            this.manualDC.Controls.Add(this.pbDCSign);
            this.manualDC.Enabled = false;
            this.manualDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.manualDC.Location = new System.Drawing.Point(990, 134);
            this.manualDC.Name = "manualDC";
            this.manualDC.Size = new System.Drawing.Size(677, 218);
            this.manualDC.TabIndex = 8;
            this.manualDC.TabStop = false;
            this.manualDC.Text = "Manual";
            this.manualDC.Visible = false;
            // 
            // gbDMM
            // 
            this.gbDMM.Controls.Add(this.pbDMM);
            this.gbDMM.Controls.Add(this.statusDMM);
            this.gbDMM.Controls.Add(this.valueDMM);
            this.gbDMM.Controls.Add(this.btnStopMeasure);
            this.gbDMM.Controls.Add(this.btnStartMeasure);
            this.gbDMM.Controls.Add(this.lblVoltDMM);
            this.gbDMM.Location = new System.Drawing.Point(71, 318);
            this.gbDMM.Name = "gbDMM";
            this.gbDMM.Size = new System.Drawing.Size(788, 262);
            this.gbDMM.TabIndex = 10;
            this.gbDMM.TabStop = false;
            this.gbDMM.Text = "Digital Multimeter (Agilent 34401A 6½ Digit Multimeter)";
            // 
            // statusDMM
            // 
            this.statusDMM.Controls.Add(this.tbCommandDMM);
            this.statusDMM.Controls.Add(this.lblDMMPort);
            this.statusDMM.Controls.Add(this.tbIdentDMM);
            this.statusDMM.Controls.Add(this.btnRemoteDMM);
            this.statusDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusDMM.Location = new System.Drawing.Point(379, 29);
            this.statusDMM.Name = "statusDMM";
            this.statusDMM.Size = new System.Drawing.Size(395, 117);
            this.statusDMM.TabIndex = 3;
            this.statusDMM.TabStop = false;
            this.statusDMM.Text = "Status";
            // 
            // tbCommandDMM
            // 
            this.tbCommandDMM.AutoCompleteCustomSource.AddRange(new string[] {
            "*IDN?",
            "*CLS",
            "SYST:REM?",
            "READ?",
            "TRIG:SOUR?",
            "MEAS:VOLT:DC?"});
            this.tbCommandDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCommandDMM.Location = new System.Drawing.Point(39, 73);
            this.tbCommandDMM.Name = "tbCommandDMM";
            this.tbCommandDMM.Size = new System.Drawing.Size(255, 26);
            this.tbCommandDMM.TabIndex = 4;
            this.tbCommandDMM.Text = "Enter Command";
            this.tbCommandDMM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommandDMM_KeyDown);
            // 
            // lblDMMPort
            // 
            this.lblDMMPort.AutoSize = true;
            this.lblDMMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDMMPort.Location = new System.Drawing.Point(68, 3);
            this.lblDMMPort.Name = "lblDMMPort";
            this.lblDMMPort.Size = new System.Drawing.Size(47, 15);
            this.lblDMMPort.TabIndex = 6;
            this.lblDMMPort.Text = "PORT2";
            // 
            // tbIdentDMM
            // 
            this.tbIdentDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbIdentDMM.Location = new System.Drawing.Point(39, 29);
            this.tbIdentDMM.Name = "tbIdentDMM";
            this.tbIdentDMM.ReadOnly = true;
            this.tbIdentDMM.Size = new System.Drawing.Size(255, 26);
            this.tbIdentDMM.TabIndex = 3;
            // 
            // btnRemoteDMM
            // 
            this.btnRemoteDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRemoteDMM.Location = new System.Drawing.Point(313, 27);
            this.btnRemoteDMM.Name = "btnRemoteDMM";
            this.btnRemoteDMM.Size = new System.Drawing.Size(61, 32);
            this.btnRemoteDMM.TabIndex = 1;
            this.btnRemoteDMM.TabStop = false;
            this.btnRemoteDMM.Text = "Get";
            this.btnRemoteDMM.UseVisualStyleBackColor = true;
            this.btnRemoteDMM.Click += new System.EventHandler(this.btnRemoteDMM_Click);
            // 
            // valueDMM
            // 
            this.valueDMM.AutoSize = true;
            this.valueDMM.BackColor = System.Drawing.Color.Black;
            this.valueDMM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valueDMM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valueDMM.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueDMM.ForeColor = System.Drawing.Color.LawnGreen;
            this.valueDMM.Location = new System.Drawing.Point(147, 174);
            this.valueDMM.MaximumSize = new System.Drawing.Size(275, 75);
            this.valueDMM.MinimumSize = new System.Drawing.Size(275, 75);
            this.valueDMM.Name = "valueDMM";
            this.valueDMM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valueDMM.Size = new System.Drawing.Size(275, 75);
            this.valueDMM.TabIndex = 6;
            this.valueDMM.Text = "---.---";
            this.valueDMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueDMM.UseCompatibleTextRendering = true;
            // 
            // btnStopMeasure
            // 
            this.btnStopMeasure.Enabled = false;
            this.btnStopMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStopMeasure.Location = new System.Drawing.Point(640, 174);
            this.btnStopMeasure.Name = "btnStopMeasure";
            this.btnStopMeasure.Size = new System.Drawing.Size(86, 75);
            this.btnStopMeasure.TabIndex = 1;
            this.btnStopMeasure.TabStop = false;
            this.btnStopMeasure.Text = "Stop";
            this.btnStopMeasure.UseVisualStyleBackColor = true;
            this.btnStopMeasure.Click += new System.EventHandler(this.btnStopMeasure_Click);
            // 
            // btnStartMeasure
            // 
            this.btnStartMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStartMeasure.Location = new System.Drawing.Point(548, 174);
            this.btnStartMeasure.Name = "btnStartMeasure";
            this.btnStartMeasure.Size = new System.Drawing.Size(86, 75);
            this.btnStartMeasure.TabIndex = 1;
            this.btnStartMeasure.TabStop = false;
            this.btnStartMeasure.Text = "Measure";
            this.btnStartMeasure.UseVisualStyleBackColor = true;
            this.btnStartMeasure.Click += new System.EventHandler(this.btnStartMeasure_Click);
            // 
            // lblVoltDMM
            // 
            this.lblVoltDMM.AutoSize = true;
            this.lblVoltDMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltDMM.Location = new System.Drawing.Point(444, 184);
            this.lblVoltDMM.Name = "lblVoltDMM";
            this.lblVoltDMM.Size = new System.Drawing.Size(98, 55);
            this.lblVoltDMM.TabIndex = 6;
            this.lblVoltDMM.Text = "mV";
            // 
            // gbDC
            // 
            this.gbDC.Controls.Add(this.lblToggleOn);
            this.gbDC.Controls.Add(this.lblToggleOff);
            this.gbDC.Controls.Add(this.statusDC);
            this.gbDC.Controls.Add(this.btnToggleOff);
            this.gbDC.Controls.Add(this.btnToggleOn);
            this.gbDC.Controls.Add(this.pbDC);
            this.gbDC.Controls.Add(this.setPointManual);
            this.gbDC.Location = new System.Drawing.Point(71, 25);
            this.gbDC.Name = "gbDC";
            this.gbDC.Size = new System.Drawing.Size(788, 287);
            this.gbDC.TabIndex = 9;
            this.gbDC.TabStop = false;
            this.gbDC.Text = "DC Source (Chroma 62100H Series)";
            // 
            // lblToggleOn
            // 
            this.lblToggleOn.AutoSize = true;
            this.lblToggleOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.lblToggleOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblToggleOn.ForeColor = System.Drawing.Color.Black;
            this.lblToggleOn.Location = new System.Drawing.Point(271, 202);
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
            this.lblToggleOff.Location = new System.Drawing.Point(323, 203);
            this.lblToggleOff.Name = "lblToggleOff";
            this.lblToggleOff.Size = new System.Drawing.Size(37, 16);
            this.lblToggleOff.TabIndex = 5;
            this.lblToggleOff.Text = "OFF";
            // 
            // statusDC
            // 
            this.statusDC.Controls.Add(this.tbCommandDC);
            this.statusDC.Controls.Add(this.tbIdentDC);
            this.statusDC.Controls.Add(this.lblDCPort);
            this.statusDC.Controls.Add(this.btnRemoteDC);
            this.statusDC.Controls.Add(this.btnClearDC);
            this.statusDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusDC.Location = new System.Drawing.Point(379, 25);
            this.statusDC.Name = "statusDC";
            this.statusDC.Size = new System.Drawing.Size(395, 117);
            this.statusDC.TabIndex = 3;
            this.statusDC.TabStop = false;
            this.statusDC.Text = "Status";
            // 
            // tbCommandDC
            // 
            this.tbCommandDC.AutoCompleteCustomSource.AddRange(new string[] {
            "*IDN?",
            "*CLS",
            "CONF:REM ON",
            "CONF:REM OFF",
            "CONF:OUTP ON",
            "CONF:OUTP OFF",
            "CONF:OUTP?",
            "CONF:REM?",
            "SOUR:VOLT?",
            "SOUR:CURR?"});
            this.tbCommandDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbCommandDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCommandDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbCommandDC.Location = new System.Drawing.Point(39, 73);
            this.tbCommandDC.Name = "tbCommandDC";
            this.tbCommandDC.Size = new System.Drawing.Size(255, 26);
            this.tbCommandDC.TabIndex = 4;
            this.tbCommandDC.Text = "Enter Command";
            this.tbCommandDC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommandDC_KeyDown);
            // 
            // tbIdentDC
            // 
            this.tbIdentDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbIdentDC.Location = new System.Drawing.Point(39, 29);
            this.tbIdentDC.Name = "tbIdentDC";
            this.tbIdentDC.ReadOnly = true;
            this.tbIdentDC.Size = new System.Drawing.Size(255, 26);
            this.tbIdentDC.TabIndex = 3;
            // 
            // lblDCPort
            // 
            this.lblDCPort.AutoSize = true;
            this.lblDCPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDCPort.Location = new System.Drawing.Point(68, 3);
            this.lblDCPort.Name = "lblDCPort";
            this.lblDCPort.Size = new System.Drawing.Size(47, 15);
            this.lblDCPort.TabIndex = 6;
            this.lblDCPort.Text = "PORT1";
            // 
            // btnRemoteDC
            // 
            this.btnRemoteDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRemoteDC.Location = new System.Drawing.Point(313, 27);
            this.btnRemoteDC.Name = "btnRemoteDC";
            this.btnRemoteDC.Size = new System.Drawing.Size(61, 32);
            this.btnRemoteDC.TabIndex = 1;
            this.btnRemoteDC.TabStop = false;
            this.btnRemoteDC.Text = "Get";
            this.btnRemoteDC.UseVisualStyleBackColor = true;
            this.btnRemoteDC.Click += new System.EventHandler(this.btnRemoteDC_Click);
            // 
            // btnClearDC
            // 
            this.btnClearDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearDC.Location = new System.Drawing.Point(313, 70);
            this.btnClearDC.Name = "btnClearDC";
            this.btnClearDC.Size = new System.Drawing.Size(61, 32);
            this.btnClearDC.TabIndex = 1;
            this.btnClearDC.TabStop = false;
            this.btnClearDC.Text = "Reset";
            this.btnClearDC.UseVisualStyleBackColor = true;
            this.btnClearDC.Click += new System.EventHandler(this.btnClearDC_Click);
            // 
            // setPointManual
            // 
            this.setPointManual.Controls.Add(this.currBoxManual);
            this.setPointManual.Controls.Add(this.voltBoxManual);
            this.setPointManual.Controls.Add(this.btnSetCurrManual);
            this.setPointManual.Controls.Add(this.btnSetVoltManual);
            this.setPointManual.Controls.Add(this.lblCurrManual);
            this.setPointManual.Controls.Add(this.lblCurrManual2);
            this.setPointManual.Controls.Add(this.lblVoltManual2);
            this.setPointManual.Controls.Add(this.lblVoltManual);
            this.setPointManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.setPointManual.Location = new System.Drawing.Point(380, 148);
            this.setPointManual.Name = "setPointManual";
            this.setPointManual.Size = new System.Drawing.Size(395, 117);
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
            this.currBoxManual.Location = new System.Drawing.Point(113, 74);
            this.currBoxManual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.currBoxManual.Name = "currBoxManual";
            this.currBoxManual.Size = new System.Drawing.Size(103, 26);
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
            this.voltBoxManual.Location = new System.Drawing.Point(113, 29);
            this.voltBoxManual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.voltBoxManual.Name = "voltBoxManual";
            this.voltBoxManual.Size = new System.Drawing.Size(103, 26);
            this.voltBoxManual.TabIndex = 1;
            this.voltBoxManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.voltBoxManual.ThousandsSeparator = true;
            this.voltBoxManual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voltBoxManual_KeyDown);
            // 
            // btnSetCurrManual
            // 
            this.btnSetCurrManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetCurrManual.Location = new System.Drawing.Point(255, 70);
            this.btnSetCurrManual.Name = "btnSetCurrManual";
            this.btnSetCurrManual.Size = new System.Drawing.Size(118, 32);
            this.btnSetCurrManual.TabIndex = 1;
            this.btnSetCurrManual.TabStop = false;
            this.btnSetCurrManual.Text = "Set";
            this.btnSetCurrManual.UseVisualStyleBackColor = true;
            this.btnSetCurrManual.Click += new System.EventHandler(this.btnSetCurrManual_Click);
            // 
            // btnSetVoltManual
            // 
            this.btnSetVoltManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetVoltManual.Location = new System.Drawing.Point(255, 25);
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
            this.lblCurrManual.Location = new System.Drawing.Point(37, 76);
            this.lblCurrManual.Name = "lblCurrManual";
            this.lblCurrManual.Size = new System.Drawing.Size(70, 20);
            this.lblCurrManual.TabIndex = 0;
            this.lblCurrManual.Text = "Current :";
            // 
            // lblCurrManual2
            // 
            this.lblCurrManual2.AutoSize = true;
            this.lblCurrManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCurrManual2.Location = new System.Drawing.Point(227, 76);
            this.lblCurrManual2.Name = "lblCurrManual2";
            this.lblCurrManual2.Size = new System.Drawing.Size(20, 20);
            this.lblCurrManual2.TabIndex = 0;
            this.lblCurrManual2.Text = "A";
            // 
            // lblVoltManual2
            // 
            this.lblVoltManual2.AutoSize = true;
            this.lblVoltManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVoltManual2.Location = new System.Drawing.Point(227, 31);
            this.lblVoltManual2.Name = "lblVoltManual2";
            this.lblVoltManual2.Size = new System.Drawing.Size(20, 20);
            this.lblVoltManual2.TabIndex = 0;
            this.lblVoltManual2.Text = "V";
            // 
            // lblVoltManual
            // 
            this.lblVoltManual.AutoSize = true;
            this.lblVoltManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVoltManual.Location = new System.Drawing.Point(35, 31);
            this.lblVoltManual.Name = "lblVoltManual";
            this.lblVoltManual.Size = new System.Drawing.Size(72, 20);
            this.lblVoltManual.TabIndex = 0;
            this.lblVoltManual.Text = "Voltage :";
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
            "220000001812280001",
            "220010002108260001",
            "220050002108160001",
            "220000002107260001",
            "DES202012080061900001",
            "292A01977RTA10780001"});
            this.tbSn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSn.Location = new System.Drawing.Point(164, 70);
            this.tbSn.MaxLength = 22;
            this.tbSn.Name = "tbSn";
            this.tbSn.Size = new System.Drawing.Size(205, 26);
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
            this.programList.Location = new System.Drawing.Point(164, 25);
            this.programList.Name = "programList";
            this.programList.Size = new System.Drawing.Size(205, 28);
            this.programList.TabIndex = 1;
            this.programList.SelectionChangeCommitted += new System.EventHandler(this.programList_SelectionChangeCommitted);
            // 
            // editSpecTest
            // 
            this.editSpecTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editSpecTest.Controls.Add(this.delProgBtn);
            this.editSpecTest.Controls.Add(this.clearBtn);
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
            // delProgBtn
            // 
            this.delProgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delProgBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.delProgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.delProgBtn.Location = new System.Drawing.Point(538, 132);
            this.delProgBtn.Name = "delProgBtn";
            this.delProgBtn.Size = new System.Drawing.Size(121, 64);
            this.delProgBtn.TabIndex = 2;
            this.delProgBtn.TabStop = false;
            this.delProgBtn.Text = "Delete Selected Program";
            this.delProgBtn.UseVisualStyleBackColor = false;
            this.delProgBtn.Click += new System.EventHandler(this.delProgBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(538, 202);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 64);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTable2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTable2.BackgroundColor = System.Drawing.Color.White;
            this.gridTable2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTable2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridTable2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editContactPairs,
            this.editMaxRes});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridTable2.Location = new System.Drawing.Point(16, 29);
            this.gridTable2.Name = "gridTable2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridTable2.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridTable2.Size = new System.Drawing.Size(510, 237);
            this.gridTable2.TabIndex = 7;
            // 
            // editContactPairs
            // 
            this.editContactPairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editContactPairs.DefaultCellStyle = dataGridViewCellStyle3;
            this.editContactPairs.HeaderText = "Contact Pairs";
            this.editContactPairs.Name = "editContactPairs";
            // 
            // editMaxRes
            // 
            this.editMaxRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editMaxRes.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.btnClearData.BackColor = System.Drawing.Color.Red;
            this.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Location = new System.Drawing.Point(876, 209);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(76, 57);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear ";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // gridTable1
            // 
            this.gridTable1.AllowUserToOrderColumns = true;
            this.gridTable1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridTable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTable1.BackgroundColor = System.Drawing.Color.White;
            this.gridTable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTable1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactPairs,
            this.maxRes,
            this.measVolt,
            this.res,
            this.result});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridTable1.Location = new System.Drawing.Point(16, 29);
            this.gridTable1.Name = "gridTable1";
            this.gridTable1.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridTable1.RowHeadersVisible = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable1.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gridTable1.Size = new System.Drawing.Size(854, 237);
            this.gridTable1.TabIndex = 5;
            // 
            // contactPairs
            // 
            this.contactPairs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactPairs.DefaultCellStyle = dataGridViewCellStyle10;
            this.contactPairs.FillWeight = 150F;
            this.contactPairs.HeaderText = "Contact Pairs";
            this.contactPairs.Name = "contactPairs";
            this.contactPairs.ReadOnly = true;
            // 
            // maxRes
            // 
            this.maxRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maxRes.DefaultCellStyle = dataGridViewCellStyle11;
            this.maxRes.HeaderText = "Max.Res (mΩ)";
            this.maxRes.Name = "maxRes";
            this.maxRes.ReadOnly = true;
            // 
            // measVolt
            // 
            this.measVolt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.measVolt.DefaultCellStyle = dataGridViewCellStyle12;
            this.measVolt.HeaderText = "Voltage (mV)";
            this.measVolt.Name = "measVolt";
            this.measVolt.ReadOnly = true;
            // 
            // res
            // 
            this.res.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.res.DefaultCellStyle = dataGridViewCellStyle13;
            this.res.HeaderText = "Res (mΩ)";
            this.res.Name = "res";
            this.res.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.result.DefaultCellStyle = dataGridViewCellStyle14;
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // saveData
            // 
            this.saveData.CheckPathExists = false;
            this.saveData.DefaultExt = "xlsx";
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
            // ss
            // 
            this.ss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.ss.Location = new System.Drawing.Point(0, 727);
            this.ss.Name = "ss";
            this.ss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ss.Size = new System.Drawing.Size(983, 22);
            this.ss.SizingGrip = false;
            this.ss.TabIndex = 10;
            this.ss.Text = "statusStrip1";
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
            // pbDMM
            // 
            this.pbDMM.Image = global::PE.Properties.Resources._34401DMM;
            this.pbDMM.Location = new System.Drawing.Point(58, 29);
            this.pbDMM.Name = "pbDMM";
            this.pbDMM.Size = new System.Drawing.Size(284, 123);
            this.pbDMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDMM.TabIndex = 8;
            this.pbDMM.TabStop = false;
            // 
            // btnToggleOff
            // 
            this.btnToggleOff.ErrorImage = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.Image = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.InitialImage = global::PE.Properties.Resources.icons8_toggle_off_64;
            this.btnToggleOff.Location = new System.Drawing.Point(263, 172);
            this.btnToggleOff.Name = "btnToggleOff";
            this.btnToggleOff.Size = new System.Drawing.Size(106, 77);
            this.btnToggleOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleOff.TabIndex = 4;
            this.btnToggleOff.TabStop = false;
            this.btnToggleOff.Click += new System.EventHandler(this.btnToggleOff_Click);
            // 
            // btnToggleOn
            // 
            this.btnToggleOn.ErrorImage = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.Image = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.InitialImage = global::PE.Properties.Resources.icons8_toggle_on_64;
            this.btnToggleOn.Location = new System.Drawing.Point(263, 171);
            this.btnToggleOn.Name = "btnToggleOn";
            this.btnToggleOn.Size = new System.Drawing.Size(106, 77);
            this.btnToggleOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleOn.TabIndex = 4;
            this.btnToggleOn.TabStop = false;
            this.btnToggleOn.Visible = false;
            this.btnToggleOn.Click += new System.EventHandler(this.btnToggleOn_Click);
            // 
            // pbDC
            // 
            this.pbDC.Image = global::PE.Properties.Resources.CHR_62000H;
            this.pbDC.Location = new System.Drawing.Point(26, 30);
            this.pbDC.Name = "pbDC";
            this.pbDC.Size = new System.Drawing.Size(343, 112);
            this.pbDC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDC.TabIndex = 8;
            this.pbDC.TabStop = false;
            // 
            // pbDMMSign
            // 
            this.pbDMMSign.ErrorImage = global::PE.Properties.Resources.icons8_voltmeter_64;
            this.pbDMMSign.Image = global::PE.Properties.Resources.icons8_voltmeter_641;
            this.pbDMMSign.InitialImage = global::PE.Properties.Resources.icons8_voltmeter_642;
            this.pbDMMSign.Location = new System.Drawing.Point(6, 321);
            this.pbDMMSign.Name = "pbDMMSign";
            this.pbDMMSign.Size = new System.Drawing.Size(59, 43);
            this.pbDMMSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDMMSign.TabIndex = 7;
            this.pbDMMSign.TabStop = false;
            // 
            // pbDCSign
            // 
            this.pbDCSign.ErrorImage = global::PE.Properties.Resources.icons8_energy_meter_641;
            this.pbDCSign.Image = global::PE.Properties.Resources.icons8_energy_meter_64;
            this.pbDCSign.InitialImage = global::PE.Properties.Resources.icons8_energy_meter_642;
            this.pbDCSign.Location = new System.Drawing.Point(14, 25);
            this.pbDCSign.Name = "pbDCSign";
            this.pbDCSign.Size = new System.Drawing.Size(51, 43);
            this.pbDCSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDCSign.TabIndex = 7;
            this.pbDCSign.TabStop = false;
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
            // dangerOn
            // 
            this.dangerOn.ErrorImage = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.Image = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.InitialImage = global::PE.Properties.Resources.Artboard_56;
            this.dangerOn.Location = new System.Drawing.Point(11, 65);
            this.dangerOn.Name = "dangerOn";
            this.dangerOn.Size = new System.Drawing.Size(450, 147);
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
            this.dmm34401a.Location = new System.Drawing.Point(130, 29);
            this.dmm34401a.Name = "dmm34401a";
            this.dmm34401a.Size = new System.Drawing.Size(193, 76);
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
            this.startTool.ToolTipText = "Click to start program.";
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
            this.homeTool.ToolTipText = "Go to homepage.";
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
            this.editTool.ToolTipText = "Go to edit program.";
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
            this.manualTool.ToolTipText = "Go to equipment manual.";
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
            this.databaseTool.ToolTipText = "Click to open PE database.";
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
            this.exportTool.ToolTipText = "Click to export data.";
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
            this.shutdownTool.ToolTipText = "Exit program.";
            this.shutdownTool.Click += new System.EventHandler(this.shutdownTool_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Image = global::PE.Properties.Resources.icons8_open_folder_in_new_tab_32;
            this.fileOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(179, 38);
            this.fileOpen.Text = "Open...";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Enabled = false;
            this.fileSave.Image = global::PE.Properties.Resources.icons8_save_32;
            this.fileSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(179, 38);
            this.fileSave.Text = "Save...";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Enabled = false;
            this.fileSaveAs.Image = global::PE.Properties.Resources.icons8_save_as_32;
            this.fileSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveAs.Size = new System.Drawing.Size(179, 38);
            this.fileSaveAs.Text = "Save As...";
            this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // fileExit
            // 
            this.fileExit.Image = global::PE.Properties.Resources.icons8_shutdown_32;
            this.fileExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.fileExit.Size = new System.Drawing.Size(179, 38);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // configPort
            // 
            this.configPort.Image = global::PE.Properties.Resources.icons8_internet_of_things_32;
            this.configPort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configPort.Name = "configPort";
            this.configPort.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.configPort.Size = new System.Drawing.Size(235, 38);
            this.configPort.Text = "Port";
            this.configPort.Click += new System.EventHandler(this.configPort_Click);
            // 
            // configEdit
            // 
            this.configEdit.Image = global::PE.Properties.Resources.icons8_edit_32;
            this.configEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configEdit.Name = "configEdit";
            this.configEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.configEdit.Size = new System.Drawing.Size(235, 38);
            this.configEdit.Text = "Edit program";
            this.configEdit.Click += new System.EventHandler(this.configEdit_Click);
            // 
            // configManualDC
            // 
            this.configManualDC.Image = global::PE.Properties.Resources.icons8_manual_321;
            this.configManualDC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configManualDC.Name = "configManualDC";
            this.configManualDC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.configManualDC.Size = new System.Drawing.Size(235, 38);
            this.configManualDC.Text = "Manual DC-Source";
            this.configManualDC.Click += new System.EventHandler(this.configManual_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::PE.Properties.Resources.icons8_database_administrator_32;
            this.databaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // helpSpec
            // 
            this.helpSpec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpSpecBMW,
            this.helpSpecOBC,
            this.helpSpecDCB,
            this.helpSpecREN,
            this.helpSpecNIS});
            this.helpSpec.Image = global::PE.Properties.Resources.icons8_about_32;
            this.helpSpec.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpec.Name = "helpSpec";
            this.helpSpec.Size = new System.Drawing.Size(260, 38);
            this.helpSpec.Text = "Specification";
            // 
            // helpSpecBMW
            // 
            this.helpSpecBMW.Image = global::PE.Properties.Resources.BMW_32;
            this.helpSpecBMW.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpecBMW.Name = "helpSpecBMW";
            this.helpSpecBMW.Size = new System.Drawing.Size(196, 38);
            this.helpSpecBMW.Text = "BMW";
            this.helpSpecBMW.Click += new System.EventHandler(this.helpSpecBMW_Click);
            // 
            // helpSpecOBC
            // 
            this.helpSpecOBC.Image = global::PE.Properties.Resources.DAI2_32;
            this.helpSpecOBC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpecOBC.Name = "helpSpecOBC";
            this.helpSpecOBC.Size = new System.Drawing.Size(196, 38);
            this.helpSpecOBC.Text = "DAIMLER-OBC";
            this.helpSpecOBC.Click += new System.EventHandler(this.helpSpecOBC_Click);
            // 
            // helpSpecDCB
            // 
            this.helpSpecDCB.Image = global::PE.Properties.Resources.DAI2_32;
            this.helpSpecDCB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpecDCB.Name = "helpSpecDCB";
            this.helpSpecDCB.Size = new System.Drawing.Size(196, 38);
            this.helpSpecDCB.Text = "DAIMLER-DC Box";
            this.helpSpecDCB.Click += new System.EventHandler(this.helpSpecDCB_Click);
            // 
            // helpSpecREN
            // 
            this.helpSpecREN.Image = global::PE.Properties.Resources.REN2_32;
            this.helpSpecREN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpecREN.Name = "helpSpecREN";
            this.helpSpecREN.Size = new System.Drawing.Size(196, 38);
            this.helpSpecREN.Text = "Renault 5DH DCDC";
            this.helpSpecREN.Click += new System.EventHandler(this.helpSpecREN_Click);
            // 
            // helpSpecNIS
            // 
            this.helpSpecNIS.Image = global::PE.Properties.Resources.NIS_32;
            this.helpSpecNIS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpecNIS.Name = "helpSpecNIS";
            this.helpSpecNIS.Size = new System.Drawing.Size(196, 38);
            this.helpSpecNIS.Text = "Nissan-OBC";
            this.helpSpecNIS.Click += new System.EventHandler(this.helpSpecNIS_Click);
            // 
            // helpEqMan
            // 
            this.helpEqMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpEqManDC,
            this.helpEqManDMM});
            this.helpEqMan.Image = global::PE.Properties.Resources.icons8_user_manual_32;
            this.helpEqMan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpEqMan.Name = "helpEqMan";
            this.helpEqMan.Size = new System.Drawing.Size(260, 38);
            this.helpEqMan.Text = "Equipment manual";
            // 
            // helpEqManDC
            // 
            this.helpEqManDC.Name = "helpEqManDC";
            this.helpEqManDC.Size = new System.Drawing.Size(180, 22);
            this.helpEqManDC.Text = "DC-Source";
            this.helpEqManDC.Click += new System.EventHandler(this.helpEqManDC_Click);
            // 
            // helpEqManDMM
            // 
            this.helpEqManDMM.Name = "helpEqManDMM";
            this.helpEqManDMM.Size = new System.Drawing.Size(180, 22);
            this.helpEqManDMM.Text = "Digital Multimeter";
            this.helpEqManDMM.Click += new System.EventHandler(this.helpEqManDMM_Click);
            // 
            // peTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(983, 749);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.disConnect);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.groupTest);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "peTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE TESTING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
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
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.groupTest.ResumeLayout(false);
            this.manualDC.ResumeLayout(false);
            this.gbDMM.ResumeLayout(false);
            this.gbDMM.PerformLayout();
            this.statusDMM.ResumeLayout(false);
            this.statusDMM.PerformLayout();
            this.gbDC.ResumeLayout(false);
            this.gbDC.PerformLayout();
            this.statusDC.ResumeLayout(false);
            this.statusDC.PerformLayout();
            this.setPointManual.ResumeLayout(false);
            this.setPointManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currBoxManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltBoxManual)).EndInit();
            this.testProgram.ResumeLayout(false);
            this.testProgram.PerformLayout();
            this.editSpecTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable2)).EndInit();
            this.testData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable1)).EndInit();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMMSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDCSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem helpSpec;
        public System.Windows.Forms.MenuStrip ms;
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
        public System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.Label lblTestResult;
        public System.Windows.Forms.ToolStripButton databaseTool;
        public System.Windows.Forms.ToolStripButton homeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpInfo;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        public System.Windows.Forms.DataGridView gridTable1;
        private System.Windows.Forms.GroupBox testData;
        public System.Windows.Forms.SaveFileDialog saveData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox delta;
        private System.Windows.Forms.ToolStripMenuItem configEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox testProgram;
        private System.Windows.Forms.Button confirmSelectBtn;
        private System.Windows.Forms.Label lblSelectProgram;
        private System.Windows.Forms.RichTextBox rtbIncoming2;
        private System.Windows.Forms.Label lblSn;
        public System.Windows.Forms.TextBox tbSn;
        private System.Windows.Forms.GroupBox editSpecTest;
        public System.Windows.Forms.DataGridView gridTable2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editContactPairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn editMaxRes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton manualTool;
        public System.Windows.Forms.ToolStripButton shutdownTool;
        public System.Windows.Forms.ToolStripButton exportTool;
        public System.Windows.Forms.ToolStripButton editTool;
        private System.Windows.Forms.GroupBox manualDC;
        private System.Windows.Forms.GroupBox setPointManual;
        public System.Windows.Forms.NumericUpDown currBoxManual;
        public System.Windows.Forms.NumericUpDown voltBoxManual;
        private System.Windows.Forms.Button btnSetCurrManual;
        private System.Windows.Forms.Button btnSetVoltManual;
        private System.Windows.Forms.Label lblCurrManual;
        private System.Windows.Forms.Label lblCurrManual2;
        private System.Windows.Forms.Label lblVoltManual2;
        private System.Windows.Forms.Label lblVoltManual;
        private System.Windows.Forms.PictureBox btnToggleOff;
        private System.Windows.Forms.PictureBox btnToggleOn;
        private System.Windows.Forms.Label lblToggleOff;
        private System.Windows.Forms.Label lblToggleOn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem configManualDC;
        public System.Windows.Forms.ToolStripButton startTool;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnClearData;
        public System.IO.Ports.SerialPort comPort2;
        public System.Windows.Forms.Label lblDMMPort;
        public System.Windows.Forms.Label lblDCPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.PictureBox dmm34401a;
        private System.Windows.Forms.GroupBox statusDC;
        public System.Windows.Forms.TextBox tbCommandDC;
        public System.Windows.Forms.TextBox tbIdentDC;
        private System.Windows.Forms.Button btnRemoteDC;
        private System.Windows.Forms.Button btnClearDC;
        private System.Windows.Forms.GroupBox statusDMM;
        public System.Windows.Forms.TextBox tbCommandDMM;
        public System.Windows.Forms.TextBox tbIdentDMM;
        private System.Windows.Forms.Button btnRemoteDMM;
        private System.Windows.Forms.Button btnClearDMM;
        private System.Windows.Forms.PictureBox pbDCSign;
        private System.Windows.Forms.PictureBox pbDMMSign;
        private System.Windows.Forms.PictureBox pbDC;
        private System.Windows.Forms.GroupBox gbDMM;
        private System.Windows.Forms.PictureBox pbDMM;
        public System.Windows.Forms.Label valueDMM;
        private System.Windows.Forms.Label lblVoltDMM;
        private System.Windows.Forms.GroupBox gbDC;
        private System.Windows.Forms.Button btnStartMeasure;
        private System.Windows.Forms.Button btnStopMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn measVolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.ToolStripMenuItem helpSpecBMW;
        private System.Windows.Forms.ToolStripMenuItem helpSpecOBC;
        private System.Windows.Forms.ToolStripMenuItem helpSpecDCB;
        private System.Windows.Forms.ToolStripMenuItem helpSpecREN;
        private System.Windows.Forms.ToolStripMenuItem helpSpecNIS;
        public System.Windows.Forms.ComboBox programList;
        public System.Windows.Forms.Button btnCalDC;
        public System.Windows.Forms.Button btnCalDMM;
        private System.Windows.Forms.Button delProgBtn;
        private System.Windows.Forms.ToolStripMenuItem helpEqMan;
        private System.Windows.Forms.ToolStripMenuItem helpPEMan;
        private System.Windows.Forms.ToolStripMenuItem helpEqManDC;
        private System.Windows.Forms.ToolStripMenuItem helpEqManDMM;
    }
}

