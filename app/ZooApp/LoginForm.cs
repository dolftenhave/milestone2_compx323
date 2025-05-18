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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbDataset.Items.Add("Small Dataset (M2S)");
            cbDataset.Items.Add("Large Dataset (M2L)");
            cbDataset.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = cbDataset.SelectedItem.ToString();
                string prefix = selected.Contains("M2L") ? "M2L" : "M2S";

                DatabaseHelper.SetTablePrefix(prefix);
                string query = $"SELECT COUNT(*) FROM {DatabaseHelper.Table("ANIMAL")}";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                int count = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;

                //MessageBox.Show($"{selected} loaded. {count} animals found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new SelectStaffForm().ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckTables_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT table_name FROM user_tables ORDER BY table_name");

                Form popup = new Form
                {
                    Width = 400,
                    Height = 500,
                    Text = "Accessible Tables"
                };

                TextBox txtOutput = new TextBox
                {
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    ScrollBars = ScrollBars.Vertical,
                    ReadOnly = true
                };

                foreach (DataRow row in dt.Rows)
                    txtOutput.AppendText(row["TABLE_NAME"].ToString() + Environment.NewLine);

                popup.Controls.Add(txtOutput);
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tables: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
