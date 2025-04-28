using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSmallDataset_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.ConnectToDatabase())
            {
                DatabaseHelper.CheckSmallDataExists();
            }
        }

        private void btnBigDataset_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.ConnectToDatabase())
            {
                DatabaseHelper.CheckBigDataExists();
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
