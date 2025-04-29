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

        private void btnSmallDataset_Click_1(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.SetDatasetMode("M2S"); // Set prefix for small dataset

                string query = "SELECT COUNT(*) FROM M2S_ANIMAL";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                int count = Convert.ToInt32(dt.Rows[0][0]);

                MessageBox.Show($"Small dataset loaded. {count} animals found.",
                    "Dataset Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading small dataset: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBigDataset_Click_1(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.SetDatasetMode("M21"); // Set prefix for big dataset

                string query = "SELECT COUNT(*) FROM M21_ANIMAL";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                int count = Convert.ToInt32(dt.Rows[0][0]);

                MessageBox.Show($"Big dataset loaded. {count} animals found.",
                    "Dataset Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading big dataset: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
