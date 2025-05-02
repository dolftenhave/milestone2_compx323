using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddEnclosureForm : Form
    {
        private bool isEditMode = false;
        private int editingEid = -1;

        public AddEnclosureForm()
        {
            InitializeComponent();
        }

        public AddEnclosureForm(DataRow enclosureRow) : this()
        {
            if (enclosureRow != null)
            {
                isEditMode = true;
                editingEid = Convert.ToInt32(enclosureRow["eid"]);
                LoadExistingData(enclosureRow);
            }
        }

        private void AddEnclosureForm_Load(object sender, EventArgs e)
        {
            LoadZoneCombo();

            if (isEditMode)
            {
                this.Text = "Edit Enclosure";
                btnSubmit.Text = "Update";
            }
            else
            {
                this.Text = "Add New Enclosure";
                btnSubmit.Text = "Add";
            }
        }

        private void LoadZoneCombo()
        {
            string query = $"SELECT name FROM {DatabaseHelper.Table("ZONE")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cbZoneName.DataSource = dt;
            cbZoneName.DisplayMember = "name";
            cbZoneName.ValueMember = "name";
        }

        private void LoadExistingData(DataRow row)
        {
            txtBiome.Text = row["biome"].ToString();
            txtSize.Text = row["esize"].ToString();
            cbZoneName.SelectedValue = row["zoneName"].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string biome = txtBiome.Text.Trim();
                string zoneName = cbZoneName.SelectedValue.ToString();
                if (!int.TryParse(txtSize.Text.Trim(), out int size) || size <= 0)
                {
                    MessageBox.Show("Zone size must be a positive number.");
                    return;
                }

                string table = DatabaseHelper.Table("ENCLOSURE");

                if (isEditMode)
                {
                    string update = $"UPDATE {table} SET biome = :biome, esize = :size, zoneName = :zoneName WHERE eid = :eid";
                    OracleParameter[] parameters = {
                        new OracleParameter("biome", biome),
                        new OracleParameter("size", size),
                        new OracleParameter("zoneName", zoneName),
                        new OracleParameter("eid", editingEid)
                    };
                    DatabaseHelper.ExecuteNonQuery(update, parameters);
                    MessageBox.Show("Enclosure updated successfully.");
                }
                else
                {
                    string getEidQuery = $"SELECT NVL(MAX(eid), 0) + 1 FROM {table}";
                    int newEid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getEidQuery).Rows[0][0]);

                    string insert = $"INSERT INTO {table} (eid, biome, esize, zoneName) VALUES (:eid, :biome, :size, :zoneName)";
                    OracleParameter[] parameters = {
                        new OracleParameter("eid", newEid),
                        new OracleParameter("biome", biome),
                        new OracleParameter("size", size),
                        new OracleParameter("zoneName", zoneName)
                    };
                    DatabaseHelper.ExecuteNonQuery(insert, parameters);
                    MessageBox.Show("Enclosure added successfully.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
