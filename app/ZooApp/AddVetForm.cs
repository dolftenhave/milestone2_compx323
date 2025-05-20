/**
 * AddVetForm.cs
 *
 * Handles assigning and managing vet clinic assignments.
 * Allows Add, Update, Delete of clinic names and assigning them to selected vets.
 * Only staff in the Care table are treated as Vets.
 *
 * @author Min Soe Htut
 */

using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
                SetCurrentClinic(currentSid.Value);
            }

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadVetList()
        {
            string query = $@"
                SELECT sid, fName || ' ' || lName AS fullName
                FROM m2s_Staff
                WHERE sid IN (SELECT DISTINCT staffID FROM m2s_Care)
                   OR sid = :sid";

            OracleParameter[] param = { new OracleParameter("sid", currentSid ?? -1) };
            DataTable vets = DatabaseHelper.ExecuteQuery(query, param);

            cbSelectVet.Items.Clear();
            foreach (DataRow row in vets.Rows)
            {
                cbSelectVet.Items.Add(new ComboBoxItem(row["fullName"].ToString(), row["sid"].ToString()));
            }

            cbSelectVet.SelectedIndexChanged += cbSelectVet_SelectedIndexChanged;
        }

        private void LoadClinicList()
        {
            cbClinics.Items.Clear();
            cbClinics.Items.Add("Add New Clinic");

            string query = "SELECT DISTINCT clinic FROM m2s_Staff WHERE clinic IS NOT NULL ORDER BY clinic";
            DataTable clinics = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in clinics.Rows)
            {
                cbClinics.Items.Add(row["clinic"].ToString());
            }

            cbClinics.SelectedIndex = 0;
        }

        private void SetCurrentClinic(int sid)
        {
            string query = $"SELECT clinic FROM {DatabaseHelper.Table("Staff")} WHERE sid = :sid";
            OracleParameter[] param = { new OracleParameter("sid", sid) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, param);

            txtCurrentClinic.Text = (result.Rows.Count > 0 && result.Rows[0]["clinic"] != DBNull.Value)
                ? result.Rows[0]["clinic"].ToString()
                : "None";
        }

        private void cbSelectVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectVet.SelectedItem is ComboBoxItem selectedVet)
            {
                SetCurrentClinic(int.Parse(selectedVet.Value));
                cbClinics.SelectedIndex = 0;
                btnAdd.Enabled = true;
            }
        }

        private void cbClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClinics.SelectedIndex == 0)
            {
                txtClinicName.Clear();
                btnAdd.Enabled = cbSelectVet.SelectedItem != null;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                txtClinicName.Text = cbClinics.SelectedItem.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(cbSelectVet.SelectedItem is ComboBoxItem selectedVet))
            {
                MessageBox.Show("Please select a vet before adding a clinic.");
                return;
            }

            string newClinic = txtClinicName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newClinic))
            {
                MessageBox.Show("Please enter a clinic name.");
                return;
            }

            string checkQuery = $"SELECT 1 FROM {DatabaseHelper.Table("Staff")} WHERE LOWER(clinic) = LOWER(:clinic)";
            OracleParameter[] checkParams = { new OracleParameter("clinic", newClinic) };
            if (DatabaseHelper.ExecuteQuery(checkQuery, checkParams).Rows.Count > 0)
            {
                MessageBox.Show("Clinic already exists.");
                return;
            }

            string assignQuery = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :clinic WHERE sid = :sid";
            OracleParameter[] assignParams = {
                new OracleParameter("clinic", newClinic),
                new OracleParameter("sid", int.Parse(selectedVet.Value))
            };

            DatabaseHelper.ExecuteNonQuery(assignQuery, assignParams);
            MessageBox.Show("New clinic added and assigned.");
            txtClinicName.Clear();
            LoadClinicList();
            SetCurrentClinic(int.Parse(selectedVet.Value));
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbSelectVet.SelectedItem is ComboBoxItem vet && cbClinics.SelectedItem is string selectedClinic && cbClinics.SelectedIndex != 0)
            {
                string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :clinic WHERE sid = :sid";
                OracleParameter[] parameters = {
                    new OracleParameter("clinic", selectedClinic),
                    new OracleParameter("sid", int.Parse(vet.Value))
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Clinic assigned to vet.");
                LoadClinicList();
                SetCurrentClinic(int.Parse(vet.Value));
            }
            else
            {
                MessageBox.Show("Please select a vet and a clinic.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbClinics.SelectedItem == null || cbClinics.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an existing clinic to update.");
                return;
            }

            string oldClinic = cbClinics.SelectedItem.ToString();
            string newClinic = txtClinicName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newClinic))
            {
                MessageBox.Show("Enter a new clinic name.");
                return;
            }

            string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = :new WHERE clinic = :old";
            OracleParameter[] parameters = {
                new OracleParameter("new", newClinic),
                new OracleParameter("old", oldClinic)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Clinic updated.");
            txtClinicName.Clear();
            LoadClinicList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbClinics.SelectedItem == null || cbClinics.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an existing clinic to delete.");
                return;
            }

            var confirm = MessageBox.Show("This will remove the clinic assignment from all vets. Continue?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            string clinic = cbClinics.SelectedItem.ToString();
            string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = NULL WHERE clinic = :clinic";
            OracleParameter[] parameters = { new OracleParameter("clinic", clinic) };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Clinic deleted.");
            txtClinicName.Clear();
            LoadClinicList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ComboBoxItem class used in vet and clinic dropdowns
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
