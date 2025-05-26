using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    /// <summary>
    /// Login form that allows the user to choose between MongoDB and Oracle datasets.
    /// @author Min Soe Htut
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populates the combo box with dataset options on form load.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbDataset.Items.Add("MongoDB Dataset");
            cbDataset.Items.Add("Small Dataset (M2S)");
            cbDataset.Items.Add("Large Dataset (M2L)");
            cbDataset.SelectedIndex = 0; // MongoDB is default
        }

        /// <summary>
        /// Handles the connect button click event.
        /// Connects to MongoDB or Oracle based on selected dataset.
        /// </summary>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = cbDataset.SelectedItem.ToString();

                if (selected.Contains("MongoDB"))
                {
                    // MongoDB selected
                    MongoDBHelper.Initialize("Zoo");
                    var testData = MongoDBHelper.FindAll("Staff");

                    MessageBox.Show(
                        $"MongoDB Zoo database connected. {testData.Count} staff found.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // Oracle selected
                    string prefix = selected.Contains("M2L") ? "M2L" : "M2S";

                    DatabaseHelper.SetTablePrefix(prefix);
                    string query = $"SELECT COUNT(*) FROM {DatabaseHelper.Table("ANIMAL")}";
                    DataTable dt = DatabaseHelper.ExecuteQuery(query);
                    int count = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;

                    MessageBox.Show(
                        $"{selected} loaded. {count} animals found.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                // Proceed to next form
                this.Hide();
                new SelectStaffForm().ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Displays a list of accessible Oracle tables.
        /// </summary>
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
