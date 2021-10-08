
namespace PE
{
    partial class calDC
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbCalDC = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbDueDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbCalDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.gbCalDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOK.Location = new System.Drawing.Point(93, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(190, 27);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(92, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Cal. Date : ";
            // 
            // gbCalDC
            // 
            this.gbCalDC.Controls.Add(this.pictureBox1);
            this.gbCalDC.Controls.Add(this.mtbDueDate);
            this.gbCalDC.Controls.Add(this.mtbCalDate);
            this.gbCalDC.Controls.Add(this.lblDue);
            this.gbCalDC.Controls.Add(this.lblDate);
            this.gbCalDC.Controls.Add(this.btnOK);
            this.gbCalDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbCalDC.Location = new System.Drawing.Point(12, 5);
            this.gbCalDC.Name = "gbCalDC";
            this.gbCalDC.Size = new System.Drawing.Size(294, 134);
            this.gbCalDC.TabIndex = 3;
            this.gbCalDC.TabStop = false;
            this.gbCalDC.Text = "Calibration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::PE.Properties.Resources.icons8_timetable_64;
            this.pictureBox1.Image = global::PE.Properties.Resources.icons8_timetable_64;
            this.pictureBox1.InitialImage = global::PE.Properties.Resources.icons8_timetable_64;
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mtbDueDate
            // 
            this.mtbDueDate.Location = new System.Drawing.Point(183, 59);
            this.mtbDueDate.Mask = "00/00/0000";
            this.mtbDueDate.Name = "mtbDueDate";
            this.mtbDueDate.Size = new System.Drawing.Size(100, 26);
            this.mtbDueDate.TabIndex = 3;
            this.mtbDueDate.Text = "01012021";
            this.mtbDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDueDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbCalDate
            // 
            this.mtbCalDate.Location = new System.Drawing.Point(183, 25);
            this.mtbCalDate.Mask = "00/00/0000";
            this.mtbCalDate.Name = "mtbCalDate";
            this.mtbCalDate.Size = new System.Drawing.Size(100, 26);
            this.mtbCalDate.TabIndex = 3;
            this.mtbCalDate.Text = "01012021";
            this.mtbCalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCalDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDue.Location = new System.Drawing.Point(89, 62);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(90, 20);
            this.lblDue.TabIndex = 2;
            this.lblDue.Text = "Due Date : ";
            // 
            // calDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(315, 148);
            this.ControlBox = false;
            this.Controls.Add(this.gbCalDC);
            this.Name = "calDC";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC-Source Calibration info";
            this.gbCalDC.ResumeLayout(false);
            this.gbCalDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbCalDC;
        private System.Windows.Forms.Label lblDue;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MaskedTextBox mtbDueDate;
        public System.Windows.Forms.MaskedTextBox mtbCalDate;
    }
}