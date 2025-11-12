////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: specNIS.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 1/10/2021 15:58:00 PM
//Last Modified On : 1/10/2021 15:58:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Forms;

namespace PE
{
    public partial class specNIS : Form
    {
        public specNIS()
        {
            InitializeComponent();
        }

        //private static specNIS MsgBox;
        //private static DialogResult result = DialogResult.No;

        //public static DialogResult Show(string Caption)
        //{
        //    MsgBox = new specNIS();
        //    MsgBox.Text = Caption;
        //    MsgBox.ShowDialog();
        //    return result;
        //}

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            //result = DialogResult.Yes;
            //MsgBox.Close();
            this.Close();
        }
    }
}