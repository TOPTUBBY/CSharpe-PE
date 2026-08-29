////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: confirmDialog.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 24/8/2021 12:00:00 PM
//Last Modified On : 08/09/2021 14:42:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace PE
{
    public partial class confirmDialog : Form
    {
        public confirmDialog()
        {
            InitializeComponent();
        }

        private static confirmDialog MsgBox;
        private static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption)
        {
            result = DialogResult.No;
            using (MsgBox = new confirmDialog())
            {
                MsgBox.lblConfirm.Text = Text;
                MsgBox.Text = Caption;
                MsgBox.ShowDialog();
            }
            return result;
        }

        private void pbY_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void pbX_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            MsgBox.Close();
        }
    }
}