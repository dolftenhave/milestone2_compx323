using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private void btnBigDataset_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.ConnectToDatabase())
            {
                DatabaseHelper.CheckBigDataExists();

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
