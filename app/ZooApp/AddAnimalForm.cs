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
        private string selectedSpecies = "";

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
                string enclosureQuery = "SELECT eid, biome FROM m2s_enclosure ORDER BY eid";
                DataTable enclosureTable = DatabaseHelper.ExecuteQuery(enclosureQuery);
                cbEnclosure.DisplayMember = "biome";
                cbEnclosure.ValueMember = "eid";
                cbEnclosure.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEnclosure.DataSource = enclosureTable;

                cbSex.DisplayMember = "Value";
                cbSex.ValueMember = "Key";
                cbSex.DataSource = new List<KeyValuePair<string, string>> {
                    new KeyValuePair<string, string>("M", "Male"),
                    new KeyValuePair<string, string>("F", "Female")
                };

                if (!isEditMode)
                {
                    cbSex.SelectedIndex = 0;
                    lblSelectedSpecies.Text = "No species selected";
                    this.Text = "Add New Animal";
                    btnSubmit.Text = "Add Animal";
                }
                else
                {
                    lblSelectedSpecies.Text = selectedSpecies;
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
            selectedSpecies = row["speciesName"].ToString();
            lblSelectedSpecies.Text = $"Selected: {selectedSpecies}";
            dtpDOB.Value = Convert.ToDateTime(row["dob"]);
            txtWeight.Text = row["weight"].ToString();
            txtCountry.Text = row["originCountry"].ToString();
            txtFeedingInterval.Text = row["feedingInterval"].ToString();
            cbSex.SelectedValue = row["sex"].ToString();
            cbEnclosure.SelectedValue = Convert.ToInt32(row["enclosureID"]);
        }

        private void btnSelectSpecies_Click(object sender, EventArgs e)
        {
            using (var speciesForm = new SelectSpeciesForm())
            {
                if (speciesForm.ShowDialog() == DialogResult.OK)
                {
                    selectedSpecies = speciesForm.SelectedSpeciesName;
                    lblSelectedSpecies.Text = $"Selected: {selectedSpecies}";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAnimalName.Text.Trim();
                string species = selectedSpecies.Trim();
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

                if (string.IsNullOrEmpty(species))
                {
                    MessageBox.Show("Please select a species.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string table = DatabaseHelper.Table("ANIMAL");

                if (isEditMode)
                {
                    string update = $@"UPDATE {table} 
                        SET sex = :sex, feedingInterval = :feedingInterval, name = :name,
                            weight = :weight, originCountry = :originCountry, dob = :dob,
                            enclosureID = :enclosureID, speciesName = :speciesName
                        WHERE aid = :aid";

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

                    string insert = $@"INSERT INTO {table} 
                        (aid, sex, feedingInterval, name, weight, originCountry, dob, enclosureID, speciesName)
                        VALUES (:aid, :sex, :feedingInterval, :name, :weight, :originCountry, :dob, :enclosureID, :speciesName)";

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
