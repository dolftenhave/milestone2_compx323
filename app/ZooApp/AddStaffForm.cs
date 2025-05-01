using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddStaffForm : Form
    {
        private bool isEditMode = false;
        private int editingSid = -1;

        public AddStaffForm()
        {
            InitializeComponent();
        }

        public AddStaffForm(DataRow staffRow) : this()
        {
            if (staffRow != null)
            {
                isEditMode = true;
                editingSid = Convert.ToInt32(staffRow["sid"]);
                LoadExistingData(staffRow);
            }
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            cbSex.Items.Clear();
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            if (!isEditMode)
            {
                cbSex.SelectedIndex = 0;
                this.Text = "Add New Staff";
                btnSubmit.Text = "Submit";
            }
            else
            {
                this.Text = "Edit Staff";
                btnSubmit.Text = "Update";
            }
        }

        private void LoadExistingData(DataRow row)
        {
            txtFirstName.Text = row["fName"].ToString();
            txtLastName.Text = row["lName"].ToString();
            dtpDOB.Value = Convert.ToDateTime(row["dob"]);
            txtPhone.Text = row["phNumber"].ToString();
            txtEmail.Text = row["email"].ToString();
            txtStreetNumber.Text = row["streetNumber"].ToString();
            txtStreetName.Text = row["streetName"].ToString();
            txtSuburb.Text = row["suburb"].ToString();
            txtCity.Text = row["city"].ToString();
            txtPostCode.Text = row["postCode"].ToString();
            txtClinic.Text = row["clinic"].ToString();
            cbSex.SelectedItem = row["sex"].ToString() == "M" ? "Male" : "Female";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFirstName.Text.Trim();
                string lname = txtLastName.Text.Trim();
                DateTime dob = dtpDOB.Value;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sex = cbSex.SelectedItem?.ToString() == "Male" ? "M" : "F";

                if (!int.TryParse(txtStreetNumber.Text, out int streetNumber))
                    throw new Exception("Invalid street number");

                string streetName = txtStreetName.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();
                string postCode = txtPostCode.Text.Trim();
                string clinic = txtClinic.Text.Trim();

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("First name, last name, and email are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isEditMode)
                {
                    string update = @"UPDATE m2s_staff SET fName = :fName, lName = :lName, dob = :dob, phNumber = :phNumber,
                                      email = :email, streetNumber = :streetNumber, streetName = :streetName, suburb = :suburb,
                                      city = :city, postCode = :postCode, clinic = :clinic, sex = :sex WHERE sid = :sid";

                    OracleParameter[] updateParams = new OracleParameter[]
                    {
                        new OracleParameter("fName", fname),
                        new OracleParameter("lName", lname),
                        new OracleParameter("dob", dob),
                        new OracleParameter("phNumber", phone),
                        new OracleParameter("email", email),
                        new OracleParameter("streetNumber", streetNumber),
                        new OracleParameter("streetName", streetName),
                        new OracleParameter("suburb", suburb),
                        new OracleParameter("city", city),
                        new OracleParameter("postCode", postCode),
                        new OracleParameter("clinic", clinic),
                        new OracleParameter("sex", sex),
                        new OracleParameter("sid", editingSid)
                    };

                    DatabaseHelper.ExecuteNonQuery(update, updateParams);
                    MessageBox.Show("Staff updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string getSidQuery = "SELECT NVL(MAX(sid), 0) + 1 FROM m2s_staff";
                    int newSid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getSidQuery).Rows[0][0]);

                    string insert = @"INSERT INTO m2s_staff (sid, fName, lName, dob, phNumber, email, streetNumber, streetName, suburb, city, postCode, clinic, sex)
                                      VALUES (:sid, :fName, :lName, :dob, :phNumber, :email, :streetNumber, :streetName, :suburb, :city, :postCode, :clinic, :sex)";

                    OracleParameter[] insertParams = new OracleParameter[]
                    {
                        new OracleParameter("sid", newSid),
                        new OracleParameter("fName", fname),
                        new OracleParameter("lName", lname),
                        new OracleParameter("dob", dob),
                        new OracleParameter("phNumber", phone),
                        new OracleParameter("email", email),
                        new OracleParameter("streetNumber", streetNumber),
                        new OracleParameter("streetName", streetName),
                        new OracleParameter("suburb", suburb),
                        new OracleParameter("city", city),
                        new OracleParameter("postCode", postCode),
                        new OracleParameter("clinic", clinic),
                        new OracleParameter("sex", sex)
                    };

                    DatabaseHelper.ExecuteNonQuery(insert, insertParams);
                    MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
