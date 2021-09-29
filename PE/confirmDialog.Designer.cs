
namespace PE
{
    partial class confirmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmDialog));
            this.lblConfirm = new System.Windows.Forms.Label();
            this.pbY = new System.Windows.Forms.PictureBox();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblConfirm.Location = new System.Drawing.Point(85, 25);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(50, 24);
            this.lblConfirm.TabIndex = 1;
            this.lblConfirm.Text = "label";
            // 
            // pbY
            // 
            this.pbY.ErrorImage = global::PE.Properties.Resources.icons8_checkmark_48;
            this.pbY.Image = global::PE.Properties.Resources.icons8_checkmark_48;
            this.pbY.InitialImage = global::PE.Properties.Resources.icons8_checkmark_48;
            this.pbY.Location = new System.Drawing.Point(61, 72);
            this.pbY.Name = "pbY";
            this.pbY.Size = new System.Drawing.Size(48, 48);
            this.pbY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbY.TabIndex = 2;
            this.pbY.TabStop = false;
            this.pbY.Click += new System.EventHandler(this.pbY_Click);
            // 
            // pbX
            // 
            this.pbX.ErrorImage = global::PE.Properties.Resources.icons8_delete_48;
            this.pbX.Image = global::PE.Properties.Resources.icons8_delete_48;
            this.pbX.InitialImage = global::PE.Properties.Resources.icons8_delete_48;
            this.pbX.Location = new System.Drawing.Point(196, 72);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(48, 48);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbX.TabIndex = 2;
            this.pbX.TabStop = false;
            this.pbX.Click += new System.EventHandler(this.pbX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::PE.Properties.Resources.icons8_question_mark_48;
            this.pictureBox1.Image = global::PE.Properties.Resources.icons8_question_mark_48;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // confirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 139);
            this.ControlBox = false;
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.pbY);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "confirmDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exitScr";
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pbX;
        public System.Windows.Forms.PictureBox pbY;
    }
}