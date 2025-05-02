using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace ZooApp
{
    public partial class AddAnimalForm : Form
    {
        private bool isEditMode = false;
        private int editingAid = -1;

        public AddAnimalForm()
        {
            InitializeComponent();
        }

        public AddAnimalForm(DataRow animalRow) : this()
        {
            if (animalRow != null)
            {
                isEditMode = true;
                editingAid = Convert.ToInt32(animalRow["aid"]);
                LoadExistingData(animalRow);
            }
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load species (allow custom/new input)
                string speciesQuery = "SELECT latinName FROM m2s_species ORDER BY latinName";
                DataTable speciesTable = DatabaseHelper.ExecuteQuery(speciesQuery);
                foreach (DataRow row in speciesTable.Rows)
                    cbSpecies.Items.Add(row["latinName"].ToString());
                cbSpecies.DropDownStyle = ComboBoxStyle.DropDown;

                // Load enclosure list (must be existing)
                string enclosureQuery = "SELECT eid, biome FROM m2s_enclosure ORDER BY eid";
                DataTable enclosureTable = DatabaseHelper.ExecuteQuery(enclosureQuery);
                cbEnclosure.DisplayMember = "biome";
                cbEnclosure.ValueMember = "eid";
                cbEnclosure.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEnclosure.DataSource = enclosureTable;

                // Load sex options
                cbSex.DisplayMember = "Value";
                cbSex.ValueMember = "Key";
                cbSex.DataSource = new List<KeyValuePair<string, string>> {
                    new KeyValuePair<string, string>("M", "Male"),
                    new KeyValuePair<string, string>("F", "Female")
                };

                if (!isEditMode)
                {
                    cbSex.SelectedIndex = 0;
                    if (cbSpecies.Items.Count > 0)
                        cbSpecies.SelectedIndex = 0;
                    this.Text = "Add New Animal";
                    btnSubmit.Text = "Add Animal";
                }
                else
                {
                    this.Text = "Edit Animal";
                    btnSubmit.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExistingData(DataRow row)
        {
            txtAnimalName.Text = row["name"].ToString();
            cbSpecies.Text = row["speciesName"].ToString();
            dtpDOB.Value = Convert.ToDateTime(row["dob"]);
            txtWeight.Text = row["weight"].ToString();
            txtCountry.Text = row["originCountry"].ToString();
            txtFeedingInterval.Text = row["feedingInterval"].ToString();
            cbSex.SelectedValue = row["sex"].ToString();
            cbEnclosure.SelectedValue = Convert.ToInt32(row["enclosureID"]);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAnimalName.Text.Trim();
                string species = cbSpecies.Text.Trim();
                DateTime dob = dtpDOB.Value;
                string sex = ((KeyValuePair<string, string>)cbSex.SelectedItem).Key;
                int enclosureId = Convert.ToInt32(cbEnclosure.SelectedValue);
                int interval = int.Parse(txtFeedingInterval.Text);
                decimal weight = decimal.Parse(txtWeight.Text);
                string origin = txtCountry.Text.Trim().ToUpper();

                if (origin.Length != 3)
                {
                    MessageBox.Show("Country code must be 3 letters.");
                    return;
                }

                // Ensure species group 'Unknown' exists
                string checkGroupQuery = "SELECT COUNT(*) FROM m2s_speciesgroup WHERE groupName = 'Unknown'";
                DataTable groupCheck = DatabaseHelper.ExecuteQuery(checkGroupQuery);
                if (Convert.ToInt32(groupCheck.Rows[0][0]) == 0)
                {
                    string insertGroup = "INSERT INTO m2s_speciesgroup (groupName) VALUES ('Unknown')";
                    DatabaseHelper.ExecuteNonQuery(insertGroup, null);
                }

                // Ensure species exists
                string speciesCheckQuery = "SELECT COUNT(*) FROM m2s_species WHERE latinName = :name";
                OracleParameter[] speciesParams = { new OracleParameter("name", species) };
                DataTable checkResult = DatabaseHelper.ExecuteQuery(speciesCheckQuery, speciesParams);

                if (Convert.ToInt32(checkResult.Rows[0][0]) == 0)
                {
                    DialogResult result = MessageBox.Show($"Species '{species}' not found. Add it with default values?", "New Species", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string insertSpecies = "INSERT INTO m2s_species (latinName, commonName, requiredBiome, speciesGroup) VALUES (:name, :common, 'Unknown', 'Unknown')";
                        OracleParameter[] insertParams = {
                    new OracleParameter("name", species),
                    new OracleParameter("common", species)
                };
                        DatabaseHelper.ExecuteNonQuery(insertSpecies, insertParams);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid existing species.");
                        return;
                    }
                }

                string table = DatabaseHelper.Table("ANIMAL");

                if (isEditMode)
                {
                    string update = $"UPDATE {table} SET sex = :sex, feedingInterval = :feedingInterval, name = :name, weight = :weight, originCountry = :originCountry, dob = :dob, enclosureID = :enclosureID, speciesName = :speciesName WHERE aid = :aid";

                    OracleParameter[] parameters = {
                new OracleParameter("sex", sex),
                new OracleParameter("feedingInterval", interval),
                new OracleParameter("name", name),
                new OracleParameter("weight", weight),
                new OracleParameter("originCountry", origin),
                new OracleParameter("dob", dob),
                new OracleParameter("enclosureID", enclosureId),
                new OracleParameter("speciesName", species),
                new OracleParameter("aid", editingAid)
            };

                    DatabaseHelper.ExecuteNonQuery(update, parameters);
                    MessageBox.Show("Animal updated successfully.");
                }
                else
                {
                    string getAidQuery = $"SELECT NVL(MAX(aid), 0) + 1 FROM {table}";
                    DataTable dt = DatabaseHelper.ExecuteQuery(getAidQuery);
                    int newAid = Convert.ToInt32(dt.Rows[0][0]);

                    string insert = $"INSERT INTO {table} (aid, sex, feedingInterval, name, weight, originCountry, dob, enclosureID, speciesName) VALUES (:aid, :sex, :feedingInterval, :name, :weight, :originCountry, :dob, :enclosureID, :speciesName)";

                    OracleParameter[] parameters = {
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

                    DatabaseHelper.ExecuteNonQuery(insert, parameters);
                    MessageBox.Show("Animal added successfully.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
