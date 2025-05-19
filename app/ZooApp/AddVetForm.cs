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
            }
        }

        private void LoadVetList()
        {
            string query = @"
        SELECT sid, fName || ' ' || lName AS fullName
        FROM m2s_Staff
        WHERE sid IN (SELECT DISTINCT staffID FROM m2s_Care)
           OR sid = :sid";  // Ensure current vet sid is included

            OracleParameter[] param = {
        new OracleParameter("sid", currentSid.HasValue ? currentSid.Value : -1)
    };

            DataTable vets = DatabaseHelper.ExecuteQuery(query, param);

            cbSelectVet.Items.Clear();
            foreach (DataRow row in vets.Rows)
            {
                cbSelectVet.Items.Add(new ComboBoxItem(row["fullName"].ToString(), row["sid"].ToString()));
            }

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


        private void LoadClinicList()
        {
            string query = "SELECT DISTINCT clinic FROM m2s_Staff WHERE clinic IS NOT NULL ORDER BY clinic";

            DataTable clinics = DatabaseHelper.ExecuteQuery(query);
            lbClinics.Items.Clear();

            foreach (DataRow row in clinics.Rows)
            {
                lbClinics.Items.Add(row["clinic"].ToString());
            }
        }
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
                MessageBox.Show("Clinic assigned to vet successfully.");
                LoadClinicList();
            }
            else
            {
                MessageBox.Show("Please select a vet and enter a clinic name.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newClinic = txtClinicName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newClinic))
            {
                MessageBox.Show("Please enter a clinic name.");
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
                LoadClinicList();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem == null)
            {
                MessageBox.Show("Select a clinic to update.");
                return;
            }

            string oldClinic = lbClinics.SelectedItem.ToString();
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
            LoadClinicList();
            this.Close();
            new SelectStaffForm().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem == null)
            {
                MessageBox.Show("Select a clinic to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "This will remove this clinic assignment from all vets. Proceed?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string clinic = lbClinics.SelectedItem.ToString();
            string query = $"UPDATE {DatabaseHelper.Table("Staff")} SET clinic = NULL WHERE clinic = :clinic";
            OracleParameter[] parameters = { new OracleParameter("clinic", clinic) };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            LoadClinicList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem != null)
            {
                txtClinicName.Text = lbClinics.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// Helper class for ComboBox items with text and underlying value
        /// </summary>
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

