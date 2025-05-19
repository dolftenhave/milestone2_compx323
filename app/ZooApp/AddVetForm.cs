using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

/**
 * AddVetForm.cs
 * 
 * Handles assigning, adding, and editing veterinary clinic data.
 * Dynamically fetches staff with vet roles based on `Care` table.
 * 
 * @author Min Soe Htut
 */


namespace ZooApp
{
    public partial class AddVetForm : Form
    {
        private int? currentSid;

        public AddVetForm()
        {
            InitializeComponent();
            currentSid = null;
        }

        public AddVetForm(int sid)
        {
            InitializeComponent();
            currentSid = sid;
        }

        private void AddVetForm_Load(object sender, EventArgs e)
        {
            LoadVetList();
            LoadClinicList();

            if (currentSid.HasValue)
            {
                foreach (ComboBoxItem item in cbSelectVet.Items)
                {
                    if (item.Value == currentSid.Value.ToString())
                    {
                        cbSelectVet.SelectedItem = item;
                        break;
                    }
                }
                cbSelectVet.Enabled = false;
            }
        }

        /// <summary>
        /// Loads all staff with vet role (i.e., appear in Care table).
        /// </summary>
        private void LoadVetList()
        {
            string query = $@"
SELECT sid, fName || ' ' || lName AS fullName
FROM m2s_Staff
WHERE clinic IS NOT NULL
ORDER BY sid
";

            DataTable vets = DatabaseHelper.ExecuteQuery(query);

            cbSelectVet.Items.Clear();
            foreach (DataRow row in vets.Rows)
            {
                cbSelectVet.Items.Add(new ComboBoxItem(row["fullName"].ToString(), row["sid"].ToString()));
            }

            cbSelectVet.SelectedIndex = cbSelectVet.Items.Count > 0 ? 0 : -1;
        }

        /// <summary>
        /// Loads all distinct clinic names from staff table.
        /// </summary>
        private void LoadClinicList()
        {
            string query = $"SELECT DISTINCT clinic FROM {DatabaseHelper.Table("Staff")} WHERE clinic IS NOT NULL ORDER BY clinic";

            DataTable clinics = DatabaseHelper.ExecuteQuery(query);

            lbClinics.Items.Clear();
            foreach (DataRow row in clinics.Rows)
            {
                lbClinics.Items.Add(row["clinic"].ToString());
            }
        }

        /// <summary>
        /// When a clinic is selected, populate the textbox for potential editing.
        /// </summary>
        private void lbClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem != null)
            {
                txtClinicName.Text = lbClinics.SelectedItem.ToString();
            }
        }
        /// <summary>
        /// Assigns the clinic to the selected vet.
        /// </summary>
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbSelectVet.SelectedItem is ComboBoxItem vet && !string.IsNullOrWhiteSpace(txtClinicName.Text))
            {
                string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :clinic WHERE sid = :sid";
                OracleParameter[] parameters = {
                    new OracleParameter("clinic", txtClinicName.Text.Trim()),
                    new OracleParameter("sid", int.Parse(vet.Value))
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Clinic assigned to vet.");
                LoadClinicList();
            }
        }

        /// <summary>
        /// Adds a new clinic if not already present, and assigns it if from AddStaffForm.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newClinic = txtClinicName.Text.Trim();
            if (string.IsNullOrEmpty(newClinic))
            {
                MessageBox.Show("Enter a clinic name.");
                return;
            }

            string checkQuery = $"SELECT 1 FROM {DatabaseHelper.Table("Staff")} WHERE clinic = :clinic";
            OracleParameter[] checkParam = { new OracleParameter("clinic", newClinic) };
            if (DatabaseHelper.ExecuteQuery(checkQuery, checkParam).Rows.Count > 0)
            {
                MessageBox.Show("Clinic already exists.");
                return;
            }

            if (currentSid.HasValue)
            {
                string update = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :clinic WHERE sid = :sid";
                OracleParameter[] insertParams = {
                    new OracleParameter("clinic", newClinic),
                    new OracleParameter("sid", currentSid.Value)
                };
                DatabaseHelper.ExecuteNonQuery(update, insertParams);
                MessageBox.Show("New clinic added and assigned.");
            }

            LoadClinicList();
        }

        /// <summary>
        /// Updates a selected clinic name across all affected staff.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem == null)
            {
                MessageBox.Show("Select clinic to update.");
                return;
            }

            string oldClinic = lbClinics.SelectedItem.ToString();
            string newClinic = txtClinicName.Text.Trim();

            string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :new WHERE clinic = :old";
            OracleParameter[] parameters = {
                new OracleParameter("new", newClinic),
                new OracleParameter("old", oldClinic)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Clinic updated.");
            LoadClinicList();
        }

        /// <summary>
        /// Deletes clinic from all staff records.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem == null) return;

            var confirm = MessageBox.Show("This will remove the clinic assignment from all vets. Continue?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string clinic = lbClinics.SelectedItem.ToString();
            string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = NULL WHERE clinic = :clinic";
            OracleParameter[] parameters = { new OracleParameter("clinic", clinic) };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            LoadClinicList();
        }

        /// <summary>
        /// Cancels and returns to previous screen.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}

