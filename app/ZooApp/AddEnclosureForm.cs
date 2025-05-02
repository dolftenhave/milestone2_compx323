using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class AddEnclosureForm : Form
    {
        private bool isEdit = false;
        private int editingEid;

        public AddEnclosureForm()
        {
            InitializeComponent();
        }

        public AddEnclosureForm(DataRow row) : this()
        {
            if (row != null)
            {
                isEdit = true;
                editingEid = Convert.ToInt32(row["eid"]);
                txtBiome.Text = row["biome"].ToString();
                txtZone.Text = row["zoneName"].ToString();
                txtZoneSize.Text = row["zoneSize"].ToString();
                this.Text = "Edit Enclosure";
                btnSubmit.Text = "Update";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string biome = txtBiome.Text.Trim();
            string zone = txtZone.Text.Trim();
            string zoneSizeText = txtZoneSize.Text.Trim();

            if (string.IsNullOrWhiteSpace(biome) || string.IsNullOrWhiteSpace(zone) || string.IsNullOrWhiteSpace(zoneSizeText))
            {
                MessageBox.Show("All fields must be filled.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(zoneSizeText, out decimal zoneSize))
            {
                MessageBox.Show("Zone size must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string table = DatabaseHelper.Table("ENCLOSURE");

            try
            {
                if (isEdit)
                {
                    string update = $"UPDATE {table} SET biome = :biome, zoneName = :zone, zoneSize = :zoneSize WHERE eid = :eid";
                    OracleParameter[] parameters = {
                        new OracleParameter("biome", biome),
                        new OracleParameter("zone", zone),
                        new OracleParameter("zoneSize", zoneSize),
                        new OracleParameter("eid", editingEid)
                    };
                    DatabaseHelper.ExecuteNonQuery(update, parameters);
                    MessageBox.Show("Enclosure updated successfully.");
                }
                else
                {
                    string getEid = $"SELECT NVL(MAX(eid), 0) + 1 FROM {table}";
                    int newEid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getEid).Rows[0][0]);

                    string insert = $"INSERT INTO {table} (eid, biome, zoneName, zoneSize) VALUES (:eid, :biome, :zone, :zoneSize)";
                    OracleParameter[] parameters = {
                        new OracleParameter("eid", newEid),
                        new OracleParameter("biome", biome),
                        new OracleParameter("zone", zone),
                        new OracleParameter("zoneSize", zoneSize)
                    };
                    DatabaseHelper.ExecuteNonQuery(insert, parameters);
                    MessageBox.Show("Enclosure added successfully.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
