using System;
using System.Security.Policy;
using System.Windows.Forms;

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
            // TODO: Populate zone list dynamically from database
            cbRole.Items.AddRange(new string[] { "Vet", "Zookeeper", "General Staff" });
            cbZone.Items.AddRange(new string[] { "Zone A", "Zone B", "Zone C" });

            cbRole.SelectedIndex = 0;
            cbZone.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();
            string zone = cbZone.SelectedItem?.ToString();

            // Validation
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(zone))
            {
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            MessageBox.Show("Staff Member Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
