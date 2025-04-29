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
            try
            {
                string query = "SELECT COUNT(*) FROM M2S_ANIMAL"; // Fix table name
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);

                    if (count <= 100)
                    {
                        MessageBox.Show($"Small dataset loaded. {count} records found in Animal table.", "Small Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Warning: {count} records found. This looks bigger than a small dataset!", "Small Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No records found in the Animal table.", "Small Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking small dataset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBigDataset_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Animal"; // Or a big table like AnimalLarge if you have it
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    MessageBox.Show($"Animal table has {count} records loaded.", "Big Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records found.", "Big Dataset Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading big dataset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.TestConnection())
            {
                // Connection successful: Open MainForm
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Connection failed: Stay on LoginForm
                MessageBox.Show("Failed to connect to the database. Please check your credentials or try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
