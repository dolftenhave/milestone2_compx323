using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAnimals();
            LoadEnclosures();
            LoadStaff();
            LoadFeedings();
            LoadRoles();
        }

        private void LoadAnimals()
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("ANIMAL")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            animalsDataGridView.DataSource = dt;
        }

        private void LoadEnclosures()
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("ENCLOSURE")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            enclosuresDataGridView.DataSource = dt;
        }

        private void LoadStaff(string nameFilter = "", string roleFilter = "")
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("STAFF")} WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                query += $" AND (LOWER(fName) LIKE '%{nameFilter.ToLower()}%' OR LOWER(lName) LIKE '%{nameFilter.ToLower()}%')";
            }

            if (!string.IsNullOrWhiteSpace(roleFilter) && roleFilter != "All")
            {
                query += $" AND LOWER(clinic) = '{roleFilter.ToLower()}'";
            }

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            staffDataGridView.DataSource = dt;
        }

        private void LoadFeedings()
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("CARE")}"; // or FEED
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            feedingDataGridView.DataSource = dt;
        }

        private void btnRefreshAnimals_Click(object sender, EventArgs e) => LoadAnimals();
        private void btnRefreshEnclosures_Click(object sender, EventArgs e) => LoadEnclosures();
        private void btnRefreshStaff_Click(object sender, EventArgs e) => LoadStaff();

        private void btnRecordFeeding_Click(object sender, EventArgs e) => new FeedingForm().ShowDialog();
        private void btnRecordCare_Click(object sender, EventArgs e) => new VetForm().ShowDialog();
        private void btnAddAnimal_Click(object sender, EventArgs e) => new AddAnimalForm().ShowDialog();
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (AddStaffForm staffForm = new AddStaffForm())
            {
                staffForm.ShowDialog();
                LoadStaff(); // Refresh the staff table after closing
            }
        }

        private void btnOpenChecklist_Click(object sender, EventArgs e) => new ChecklistForm().ShowDialog();
        private void btnOpenStaffActivity_Click(object sender, EventArgs e) => new StaffActivityForm().ShowDialog();
        private void btnOpenSkills_Click(object sender, EventArgs e) => new ZookeeperSkillsForm().ShowDialog();
        private void btnOpenZoneCoverage_Click(object sender, EventArgs e) => new ZoneCoverageForm().ShowDialog();

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string name = txtStaffSearch.Text.Trim();
            string role = cbStaffRoleFilter.SelectedItem?.ToString();
            LoadStaff(name, role);
        }

        private void cbStaffRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = txtStaffSearch?.Text.Trim();
            string role = cbStaffRoleFilter.SelectedItem?.ToString();
            LoadStaff(name, role);
        }

        private void LoadRoles()
        {
            string query = $"SELECT DISTINCT clinic FROM {DatabaseHelper.Table("STAFF")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cbStaffRoleFilter.Items.Clear();
            cbStaffRoleFilter.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                cbStaffRoleFilter.Items.Add(row["clinic"].ToString());
            }

            cbStaffRoleFilter.SelectedIndex = 0;
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                DataRowView drv = staffDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    using (var form = new AddStaffForm(drv.Row))
                    {
                        form.ShowDialog();
                        LoadStaff(); // Refresh the table
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditAnimal_Click(object sender, EventArgs e)
        {
            if (animalsDataGridView.SelectedRows.Count > 0)
            {
                DataRowView rowView = animalsDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    using (var form = new AddAnimalForm(rowView.Row))
                    {
                        form.ShowDialog();
                        LoadAnimals(); // Refresh after edit
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an animal to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

