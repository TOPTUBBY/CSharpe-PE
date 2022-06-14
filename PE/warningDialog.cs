////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: warningDialog.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 1/10/2021 15:58:00 PM
//Last Modified On : 14/06/2022 12:30:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace PE
{
    public partial class warningDialog : Form
    {
        public warningDialog()
        {
            InitializeComponent();
        }

        static warningDialog MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption)
        {
            MsgBox = new warningDialog();
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }

        public static DialogResult resultCloseWarning(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                try
                {
                    MsgBox.Close();
                }
                catch
                {

                }
            }
            return result;
        }

        private void warningDialog_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            tbWarning.BackColor = Color.WhiteSmoke;
            System.Windows.Forms.Timer warningTime = new System.Windows.Forms.Timer();

            if (this.BackColor == Color.WhiteSmoke && tbWarning.BackColor == Color.WhiteSmoke)
            {
                warningTime.Start();
                System.Threading.Thread thread = new System.Threading.Thread(Blink);
                thread.Start();
            }
        }
        int count = 1;
        private void Blink(object o)
        {
            bool go = false;
            while (count > 0)
            {
                while (!go)
                {
                    this.BackColor = Color.WhiteSmoke;
                    tbWarning.BackColor = Color.WhiteSmoke;
                    go = true;
                    System.Threading.Thread.Sleep(500);
                }

                while (go)
                {
                    this.BackColor = Color.Red;
                    tbWarning.BackColor = Color.Red;
                    go = false;
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
    }
}
