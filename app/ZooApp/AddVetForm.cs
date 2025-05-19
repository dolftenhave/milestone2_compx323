using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddVetForm : Form
    {
        private readonly StaffInfo staffInfo;
        private readonly bool isEditMode = false;
        private readonly int editingSid;

        // Add mode
        public AddVetForm(StaffInfo info)
        {
            InitializeComponent();
            staffInfo = info;
            isEditMode = false;
        }

        // Edit mode
        public AddVetForm(int existingStaffId)
        {
            InitializeComponent();
            editingSid = existingStaffId;
            isEditMode = true;
        }

        private void AddVetForm_Load(object sender, EventArgs e)
        {
            LoadClinicList();

            if (isEditMode)
            {
                LoadCurrentClinic();
            }
        }

        private void LoadClinicList()
        {
            try
            {
                string query = "SELECT DISTINCT clinic FROM m2s_Staff WHERE clinic IS NOT NULL";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                lbClinics.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string clinic = row["clinic"].ToString();
                    if (!string.IsNullOrWhiteSpace(clinic))
                        lbClinics.Items.Add(clinic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load clinics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentClinic()
        {
            try
            {
                string query = "SELECT clinic FROM m2s_Staff WHERE sid = :sid";
                OracleParameter[] p = { new OracleParameter("sid", editingSid) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

                if (dt.Rows.Count > 0)
                {
                    string clinic = dt.Rows[0]["clinic"].ToString();
                    int index = lbClinics.Items.IndexOf(clinic);
                    if (index >= 0)
                        lbClinics.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load current clinic: " + ex.Message);
            }
        }

        private void btnAddClinic_Click(object sender, EventArgs e)
        {
            string newClinic = txtNewClinic.Text.Trim();

            if (string.IsNullOrWhiteSpace(newClinic))
            {
                MessageBox.Show("Enter a valid clinic name.");
                return;
            }

            bool exists = lbClinics.Items.Cast<string>()
                             .Any(c => c.Equals(newClinic, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                MessageBox.Show("Clinic already exists.");
                return;
            }

            lbClinics.Items.Add(newClinic);
            txtNewClinic.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lbClinics.SelectedItem == null)
            {
                MessageBox.Show("Please select a clinic.");
                return;
            }

            string selectedClinic = lbClinics.SelectedItem.ToString();

            try
            {
                if (isEditMode)
                {
                    string update = "UPDATE m2s_Staff SET clinic = :clinic WHERE sid = :sid";
                    OracleParameter[] p = {
                        new OracleParameter("clinic", selectedClinic),
                        new OracleParameter("sid", editingSid)
                    };
                    DatabaseHelper.ExecuteNonQuery(update, p);
                }
                else
                {
                    // Generate new sid
                    string getSid = "SELECT NVL(MAX(sid), 0) + 1 FROM m2s_Staff";
                    int newSid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getSid).Rows[0][0]);

                    // Insert staff
                    string insert = @"
                        INSERT INTO m2s_Staff 
                        (sid, fName, lName, dob, phNumber, email, streetNumber, streetName, suburb, city, postCode, clinic, sex)
                        VALUES 
                        (:sid, :fName, :lName, :dob, :phNumber, :email, :streetNumber, :streetName, :suburb, :city, :postCode, :clinic, :sex)";

                    OracleParameter[] parameters = {
                        new OracleParameter("sid", newSid),
                        new OracleParameter("fName", staffInfo.FirstName),
                        new OracleParameter("lName", staffInfo.LastName),
                        new OracleParameter("dob", staffInfo.DOB),
                        new OracleParameter("phNumber", staffInfo.Phone),
                        new OracleParameter("email", staffInfo.Email),
                        new OracleParameter("streetNumber", staffInfo.StreetNumber),
                        new OracleParameter("streetName", staffInfo.StreetName),
                        new OracleParameter("suburb", staffInfo.Suburb),
                        new OracleParameter("city", staffInfo.City),
                        new OracleParameter("postCode", staffInfo.PostCode),
                        new OracleParameter("clinic", selectedClinic),
                        new OracleParameter("sex", staffInfo.Sex)
                    };

                    DatabaseHelper.ExecuteNonQuery(insert, parameters);
                }

                MessageBox.Show("Vet saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving vet: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
