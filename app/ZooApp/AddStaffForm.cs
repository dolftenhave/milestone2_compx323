/**
 * AddStaffForm.cs
 * 
 * Handles adding, updating, and deleting staff members from the Zoo database.
 * Supports role-specific operations for Zookeepers and Vets.
 * 
 * @author Min Soe Htut
 */

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

        public AddStaffForm(int sid)
        {
            InitializeComponent();
            isEditMode = true;
            editingSid = sid;
            LoadStaffById(sid);
            btnAdd.Text = "Update";
        }

        public AddStaffForm()
        {
            InitializeComponent();
        }

        // Load the form and populate drop-downs
        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            cbSex.Items.Clear();
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.SelectedIndex = 0;

            cbRole.Items.Clear();
            cbRole.Items.AddRange(new object[] { "Zookeeper", "Vet" });
            cbRole.SelectedIndex = 0;

            txtPostCode.MaxLength = 4;

            LoadStaffComboBox();

            this.Text = "Manage Staff";
            btnAdd.Text = "Add";
        }

        // Load all staff for selection into cbSelectStaff
        private void LoadStaffComboBox()
        {
            cbSelectStaff.Items.Clear();
            cbSelectStaff.Items.Add("Add New Staff");

            DataTable staffList = DatabaseHelper.ExecuteQuery("SELECT sid, fName, lName FROM m2s_Staff ORDER BY sid");

            foreach (DataRow row in staffList.Rows)
            {
                string display = $"{row["sid"]} - {row["fName"]} {row["lName"]}";
                cbSelectStaff.Items.Add(new ComboBoxItem(display, row["sid"].ToString()));
            }

            cbSelectStaff.SelectedIndex = 0;
        }

        // Change form state based on selected staff
        private void cbSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectStaff.SelectedIndex == 0)
            {
                ClearForm();
                isEditMode = false;
                editingSid = -1;
                btnAdd.Text = "Add";
            }
            else
            {
                var selected = (ComboBoxItem)cbSelectStaff.SelectedItem;
                int sid = int.Parse(selected.Value);
                LoadStaffById(sid);
                isEditMode = true;
                editingSid = sid;
                btnAdd.Text = "Update";
            }
        }

        // Clear all textboxes and reset fields
        private void ClearForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
            }
            cbSex.SelectedIndex = 0;
            cbRole.SelectedIndex = 0;
            dtpDOB.Value = DateTime.Today;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFirstName.Text.Trim();
                string lname = txtLastName.Text.Trim();
                DateTime dob = dtpDOB.Value;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sex = cbSex.SelectedItem?.ToString() == "Male" ? "M" : "F";
                string role = cbRole.SelectedItem?.ToString();

                if (!int.TryParse(txtStreetNumber.Text, out int streetNumber))
                    throw new Exception("Invalid street number");

                string streetName = txtStreetName.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();
                string postCode = txtPostCode.Text.Trim();

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("First name, last name, email, and role are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (postCode.Length > 4)
                {
                    MessageBox.Show("Postcode must be 4 characters or less.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string getSidQuery = $"SELECT NVL(MAX(sid), 0) + 1 FROM {DatabaseHelper.Table("Staff")}";
                int newSid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getSidQuery).Rows[0][0]);

                string insert = $@"
            INSERT INTO {DatabaseHelper.Table("Staff")}
            (sid, fName, lName, dob, phNumber, email, streetNumber, streetName, suburb, city, postCode, sex)
            VALUES
            (:sid, :fName, :lName, :dob, :phNumber, :email, :streetNumber, :streetName, :suburb, :city, :postCode, :sex)";

                OracleParameter[] insertParams = {
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
            new OracleParameter("sex", sex)
        };

                DatabaseHelper.ExecuteNonQuery(insert, insertParams);

                if (role == "Zookeeper")
                    new AddZookeeperForm(newSid).ShowDialog();
                else if (role == "Vet")
                    new AddVetForm(newSid).ShowDialog();

                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Handles staff deletion with confirmation
        private void butDelete_Click(object sender, EventArgs e)
        {
            if (!isEditMode || editingSid == -1)
            {
                MessageBox.Show("Please select a staff member to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this staff?\nThis will also delete all care/feed data linked to them!",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string deleteCare = "DELETE FROM m2s_Care WHERE staffID = :sid";
                string deleteFeed = "DELETE FROM m2s_Feed WHERE staffID = :sid";
                string deleteOversees = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
                string deleteStaff = "DELETE FROM m2s_Staff WHERE sid = :sid";

                OracleParameter sidParam = new OracleParameter("sid", editingSid);
                OracleParameter[] paramArray = new OracleParameter[] { sidParam };

                DatabaseHelper.ExecuteNonQuery(deleteCare, paramArray);
                DatabaseHelper.ExecuteNonQuery(deleteFeed, paramArray);
                DatabaseHelper.ExecuteNonQuery(deleteOversees, paramArray);
                DatabaseHelper.ExecuteNonQuery(deleteStaff, paramArray);

                MessageBox.Show("Staff deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel returns to select staff screen
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectStaffForm ssf = new SelectStaffForm();
            ssf.ShowDialog();
            this.Close();
        }



        private void LoadStaffById(int sid)
        {
            string query = "SELECT * FROM m2s_Staff WHERE sid = :sid";
            OracleParameter[] param = { new OracleParameter("sid", sid) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, param);

            if (result.Rows.Count == 0) return;

            DataRow row = result.Rows[0];
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
            cbSex.SelectedItem = row["sex"].ToString() == "M" ? "Male" : "Female";

            string role = "Unknown";
            string roleCheckZK = "SELECT 1 FROM m2s_Oversees WHERE staffID = :sid FETCH FIRST 1 ROWS ONLY";
            string roleCheckVet = "SELECT 1 FROM m2s_Care WHERE staffID = :sid FETCH FIRST 1 ROWS ONLY";

            if (DatabaseHelper.ExecuteQuery(roleCheckZK, param).Rows.Count > 0)
                role = "Zookeeper";
            else if (DatabaseHelper.ExecuteQuery(roleCheckVet, param).Rows.Count > 0)
                role = "Vet";

            cbRole.SelectedItem = role;
        }


        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (!isEditMode || editingSid == -1)
            {
                MessageBox.Show("Please select a staff to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fname = txtFirstName.Text.Trim();
                string lname = txtLastName.Text.Trim();
                DateTime dob = dtpDOB.Value;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sex = cbSex.SelectedItem?.ToString() == "Male" ? "M" : "F";
                string role = cbRole.SelectedItem?.ToString();

                if (!int.TryParse(txtStreetNumber.Text, out int streetNumber))
                    throw new Exception("Invalid street number");

                string streetName = txtStreetName.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();
                string postCode = txtPostCode.Text.Trim();

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("First name, last name, email, and role are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (postCode.Length > 4)
                {
                    MessageBox.Show("Postcode must be 4 characters or less.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string update = $@"
            UPDATE {DatabaseHelper.Table("Staff")} SET 
                fName = :fName,
                lName = :lName,
                dob = :dob,
                phNumber = :phNumber,
                email = :email,
                streetNumber = :streetNumber,
                streetName = :streetName,
                suburb = :suburb,
                city = :city,
                postCode = :postCode,
                sex = :sex
            WHERE sid = :sid";

                OracleParameter[] updateParams = {
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
            new OracleParameter("sex", sex),
            new OracleParameter("sid", editingSid)
        };

                DatabaseHelper.ExecuteNonQuery(update, updateParams);

                if (role == "Zookeeper")
                    new AddZookeeperForm(editingSid).ShowDialog();
                else if (role == "Vet")
                    new AddVetForm(editingSid).ShowDialog();

                MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    /// <summary>
    /// ComboBoxItem helps store both display text and real value for ComboBox items.
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





