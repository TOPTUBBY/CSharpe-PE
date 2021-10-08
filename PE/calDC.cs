////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: calDC.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 8/10/2021 13:21:00 PM
//Last Modified On : 8/10/2021 13:21:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Forms;

namespace PE
{
    public partial class calDC : Form
    {
        public calDC()
        {
            InitializeComponent();
            mtbCalDate.Text = Properties.Settings.Default.dcCalDate;
            mtbDueDate.Text = Properties.Settings.Default.dcDueDate;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}
