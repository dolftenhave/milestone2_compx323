using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            cbSex.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = txtFirstName.Text.Trim();
                string lName = txtLastName.Text.Trim();
                DateTime dob = dtpDOB.Value;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string streetNumber = txtStreetNumber.Text.Trim();
                string streetName = txtStreetName.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();
                string postCode = txtPostCode.Text.Trim();
                string clinic = txtClinic.Text.Trim();
                string sex = cbSex.SelectedItem.ToString().StartsWith("M") ? "M" : "F";

                // Validation
                if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName) || string.IsNullOrWhiteSpace(phone) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(streetNumber) || string.IsNullOrWhiteSpace(streetName) ||
                    string.IsNullOrWhiteSpace(suburb) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(postCode))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(streetNumber, out int sNumber))
                {
                    MessageBox.Show("Street Number must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string getSidQuery = "SELECT NVL(MAX(sid), 0) + 1 FROM m2s_staff";
                DataTable dt = DatabaseHelper.ExecuteQuery(getSidQuery);
                int newSid = Convert.ToInt32(dt.Rows[0][0]);

                string insertQuery = "INSERT INTO m2s_staff (sid, fName, lName, dob, phNumber, email, streetNumber, streetName, suburb, city, postCode, clinic, sex) " +
                                     "VALUES (:sid, :fName, :lName, :dob, :phone, :email, :sNumber, :sName, :suburb, :city, :postcode, :clinic, :sex)";

                OracleParameter[] parameters = new OracleParameter[]
                {
                    new OracleParameter("sid", newSid),
                    new OracleParameter("fName", fName),
                    new OracleParameter("lName", lName),
                    new OracleParameter("dob", dob),
                    new OracleParameter("phone", phone),
                    new OracleParameter("email", email),
                    new OracleParameter("sNumber", sNumber),
                    new OracleParameter("sName", streetName),
                    new OracleParameter("suburb", suburb),
                    new OracleParameter("city", city),
                    new OracleParameter("postcode", postCode),
                    new OracleParameter("clinic", clinic),
                    new OracleParameter("sex", sex)
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                MessageBox.Show("Staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
