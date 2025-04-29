using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddEnclosureForm : Form
    {
        public AddEnclosureForm()
        {
            InitializeComponent();
        }

        private void AddEnclosureForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT name FROM m2s_zone";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cbZone.DisplayMember = "name";
                cbZone.ValueMember = "name";
                cbZone.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load zones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string biome = txtBiome.Text.Trim();
                string zoneName = cbZone.SelectedValue?.ToString();

                if (!int.TryParse(txtSize.Text.Trim(), out int size))
                {
                    MessageBox.Show("Size must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(biome) || string.IsNullOrWhiteSpace(zoneName))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get new EID
                string getEidQuery = "SELECT NVL(MAX(eid), 0) + 1 FROM m2s_enclosure";
                DataTable dt = DatabaseHelper.ExecuteQuery(getEidQuery);
                int newEid = Convert.ToInt32(dt.Rows[0][0]);

                string insertQuery = "INSERT INTO m2s_enclosure (eid, biome, eSize, zoneName) VALUES (:eid, :biome, :eSize, :zoneName)";
                OracleParameter[] parameters = new OracleParameter[]
                {
                    new OracleParameter("eid", newEid),
                    new OracleParameter("biome", biome),
                    new OracleParameter("eSize", size),
                    new OracleParameter("zoneName", zoneName)
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                MessageBox.Show("Enclosure added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add enclosure: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
