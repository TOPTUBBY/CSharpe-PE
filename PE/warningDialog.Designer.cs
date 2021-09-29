
namespace PE
{
    partial class warningDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warningDialog));
            this.lblWarning = new System.Windows.Forms.Label();
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.tbWarning = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWarning.Location = new System.Drawing.Point(122, 29);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(208, 42);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Warning !!!";
            // 
            // pbWarning
            // 
            this.pbWarning.Image = global::PE.Properties.Resources.icons8_flammable_material_64;
            this.pbWarning.Location = new System.Drawing.Point(12, 6);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(89, 86);
            this.pbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarning.TabIndex = 1;
            this.pbWarning.TabStop = false;
            // 
            // tbWarning
            // 
            this.tbWarning.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbWarning.Location = new System.Drawing.Point(27, 115);
            this.tbWarning.Multiline = true;
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.ReadOnly = true;
            this.tbWarning.Size = new System.Drawing.Size(390, 76);
            this.tbWarning.TabIndex = 0;
            this.tbWarning.TabStop = false;
            this.tbWarning.Text = "DC-Source output is \"ON\" over 10 seconds. Please turn \"OFF\".";
            // 
            // warningDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.tbWarning);
            this.Controls.Add(this.pbWarning);
            this.Controls.Add(this.lblWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "warningDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hotTimeScr";
            this.Load += new System.EventHandler(this.warningDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbWarning;
        private System.Windows.Forms.TextBox tbWarning;
    }
}