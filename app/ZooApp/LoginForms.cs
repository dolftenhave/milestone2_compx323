// LoginForm.cs
using System;
using System.Data;
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
            try
            {
                DatabaseHelper.SetTablePrefix("M2S");
                string query = "SELECT COUNT(*) FROM M2S_ANIMAL";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    MessageBox.Show($"Small dataset loaded. {count} records found in Animal table.", "Small Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading small dataset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBigDataset_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.SetTablePrefix("M21");
                string query = "SELECT COUNT(*) FROM M21_ANIMAL";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    MessageBox.Show($"Big dataset loaded. {count} records found in Animal table.", "Big Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading big dataset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
