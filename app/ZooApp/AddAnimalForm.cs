using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace ZooApp
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Species (latinName)
                string speciesQuery = "SELECT latinName FROM m2s_species";
                DataTable speciesTable = DatabaseHelper.ExecuteQuery(speciesQuery);
                foreach (DataRow row in speciesTable.Rows)
                {
                    cbSpecies.Items.Add(row["latinName"].ToString());
                }
                cbSpecies.DropDownStyle = ComboBoxStyle.DropDown;  // Allow typing new species

                // Load Enclosures (display biome, store eid)
                string enclosureQuery = "SELECT eid, biome FROM m2s_enclosure";
                DataTable enclosureTable = DatabaseHelper.ExecuteQuery(enclosureQuery);
                cbEnclosure.DisplayMember = "biome";
                cbEnclosure.ValueMember = "eid";
                cbEnclosure.DataSource = enclosureTable;

                // Load Sex options (show label, store code)
                cbSex.DisplayMember = "Value";
                cbSex.ValueMember = "Key";
                cbSex.DataSource = new List<KeyValuePair<string, string>> {
                    new KeyValuePair<string, string>("M", "Male"),
                    new KeyValuePair<string, string>("F", "Female")
                };

                cbSex.SelectedIndex = 0;
                if (cbSpecies.Items.Count > 0) cbSpecies.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading species/enclosures: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get new AID manually
                string getAidQuery = $"SELECT NVL(MAX(aid), 0) + 1 FROM {DatabaseHelper.Table("ANIMAL")}";
                DataTable dt = DatabaseHelper.ExecuteQuery(getAidQuery);
                int newAid = Convert.ToInt32(dt.Rows[0][0]);

                // Read inputs
                string name = txtAnimalName.Text.Trim();
                string species = cbSpecies.Text.Trim();  // Accept typed text
                DateTime dob = dtpDOB.Value;
                string sex = ((KeyValuePair<string, string>)cbSex.SelectedItem).Key;
                int enclosureId = Convert.ToInt32(cbEnclosure.SelectedValue);
                int interval = int.Parse(txtFeedingInterval.Text);
                decimal weight = decimal.Parse(txtWeight.Text);
                string origin = txtCountry.Text.Trim().ToUpper();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species) || string.IsNullOrWhiteSpace(origin))
                {
                    MessageBox.Show("All fields must be filled in.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearInputs();
                    return;
                }

                if (origin.Length != 3)
                {
                    MessageBox.Show("Country code must be exactly 3 letters (e.g. 'NZL').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Ensure 'Unknown' speciesGroup exists
                string groupCheckQuery = "SELECT COUNT(*) FROM m2s_speciesGroup WHERE latinName = 'Unknown'";
                DataTable groupResult = DatabaseHelper.ExecuteQuery(groupCheckQuery);
                if (Convert.ToInt32(groupResult.Rows[0][0]) == 0)
                {
                    string insertGroup = "INSERT INTO m2s_speciesGroup (latinName, commonName) VALUES ('Unknown', 'Unknown')";
                    DatabaseHelper.ExecuteNonQuery(insertGroup, new OracleParameter[0]);
                }

                // Check if species exists
                string speciesCheckQuery = "SELECT COUNT(*) FROM m2s_species WHERE latinName = :name";
                OracleParameter[] speciesParams = { new OracleParameter("name", species) };
                DataTable checkResult = DatabaseHelper.ExecuteQuery(speciesCheckQuery, speciesParams);

                if (Convert.ToInt32(checkResult.Rows[0][0]) == 0)
                {
                    // Add new species with default speciesGroup
                    string insertSpecies = "INSERT INTO m2s_species (latinName, commonName, requiredBiome, speciesGroup) " +
                                           "VALUES (:latin, :common, 'Unknown', 'Unknown')";
                    OracleParameter[] insertParams = {
                        new OracleParameter("latin", species),
                        new OracleParameter("common", species)
                    };
                    DatabaseHelper.ExecuteNonQuery(insertSpecies, insertParams);
                }

                // Insert Animal
                string table = DatabaseHelper.Table("ANIMAL");
                string query = $"INSERT INTO {table} (aid, sex, feedingInterval, name, weight, originCountry, dob, enclosureID, speciesName) " +
                               $"VALUES (:aid, :sex, :feedingInterval, :name, :weight, :originCountry, :dob, :enclosureID, :speciesName)";

                OracleParameter[] parameters = new OracleParameter[]
                {
                    new OracleParameter("aid", newAid),
                    new OracleParameter("sex", sex),
                    new OracleParameter("feedingInterval", interval),
                    new OracleParameter("name", name),
                    new OracleParameter("weight", weight),
                    new OracleParameter("originCountry", origin),
                    new OracleParameter("dob", dob),
                    new OracleParameter("enclosureID", enclosureId),
                    new OracleParameter("speciesName", species)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Animal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close this form
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputs();
            }

            // Optional: refresh animal data in main form if needed (e.g., via event or static flag)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtAnimalName.Clear();
            txtWeight.Clear();
            txtFeedingInterval.Clear();
            txtCountry.Clear();
            if (cbSpecies.Items.Count > 0) cbSpecies.SelectedIndex = 0;
            if (cbSex.Items.Count > 0) cbSex.SelectedIndex = 0;
            if (cbEnclosure.Items.Count > 0) cbEnclosure.SelectedIndex = 0;
            dtpDOB.Value = DateTime.Today;
        }
    }
}
