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
            try
            {
                LoadAnimals();
                LoadEnclosures();
                LoadStaff();
                LoadFeedingAndCare();
                LoadRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------- Loaders ---------
        private void LoadAnimals()
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("ANIMAL")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            animalsDataGridView.AutoGenerateColumns = true;
            animalsDataGridView.DataSource = dt;
        }

        private void LoadEnclosures()
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("ENCLOSURE")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            enclosuresDataGridView.AutoGenerateColumns = true;
            enclosuresDataGridView.DataSource = dt;
        }

        private void LoadStaff(string nameFilter = "", string roleFilter = "")
        {
            string table = DatabaseHelper.Table("STAFF");
            string feedTable = DatabaseHelper.Table("FEED");
            string careTable = DatabaseHelper.Table("CARE");

            string query = $@"
SELECT
    s.sid,
    s.fName || ' ' || s.lName AS fullName,
    s.dob,
    s.sex,
    s.phNumber,
    s.email,
    s.streetNumber || ' ' || s.streetName || ', ' || s.suburb || ', ' || s.city || ' ' || s.postCode AS address,
    s.clinic,
    CASE
        WHEN EXISTS (SELECT 1 FROM {feedTable} f WHERE f.staffID = s.sid) THEN 'Zookeeper'
        WHEN EXISTS (SELECT 1 FROM {careTable} c WHERE c.staffID = s.sid) THEN 'Vet'
        ELSE 'Unknown'
    END AS role
FROM {table} s
WHERE 1=1
";

            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                query += $" AND (LOWER(s.fName) LIKE '%{nameFilter.ToLower()}%' OR LOWER(s.lName) LIKE '%{nameFilter.ToLower()}%')";
            }

            if (!string.IsNullOrWhiteSpace(roleFilter) && roleFilter != "All")
            {
                if (roleFilter == "Zookeeper")
                    query += $" AND EXISTS (SELECT 1 FROM {feedTable} f WHERE f.staffID = s.sid)";
                else if (roleFilter == "Vet")
                    query += $" AND EXISTS (SELECT 1 FROM {careTable} c WHERE c.staffID = s.sid)";
            }

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            staffDataGridView.DataSource = dt;
            staffDataGridView.AutoGenerateColumns = true;
        }

        private void LoadFeedingAndCare()
        {
            string query = $@"
        SELECT 
            F.staffID,
            S.fName || ' ' || S.lName AS StaffName,
            F.animalID,
            A.name AS AnimalName,
            F.dateTime,
            'Feeding' AS Type,
            F.foodType AS FoodType,
            TO_CHAR(F.amount) AS FoodAmount,
            NULL AS CareType,
            NULL AS VetNotes
        FROM {DatabaseHelper.Table("FEED")} F
        JOIN {DatabaseHelper.Table("STAFF")} S ON F.staffID = S.sid
        JOIN {DatabaseHelper.Table("ANIMAL")} A ON F.animalID = A.aid

        UNION ALL

        SELECT 
            C.staffID,
            S.fName || ' ' || S.lName AS StaffName,
            C.animalID,
            A.name AS AnimalName,
            C.dateTime,
            'Care' AS Type,
            NULL AS FoodType,
            NULL AS FoodAmount,
            C.care AS CareType,
            C.notes AS VetNotes
        FROM {DatabaseHelper.Table("CARE")} C
        JOIN {DatabaseHelper.Table("STAFF")} S ON C.staffID = S.sid
        JOIN {DatabaseHelper.Table("ANIMAL")} A ON C.animalID = A.aid

        ORDER BY dateTime DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            feedingDataGridView.DataSource = dt;
            feedingDataGridView.AutoGenerateColumns = true;
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

        // --------- Button Clicks ---------
        private void btnRefreshAnimals_Click(object sender, EventArgs e) => LoadAnimals();
        private void btnRefreshEnclosures_Click(object sender, EventArgs e) => LoadEnclosures();
        private void btnRefreshStaff_Click(object sender, EventArgs e) => LoadStaff();

        private void btnAddAnimal_Click(object sender, EventArgs e) => new AddAnimalForm().ShowDialog();
        private void btnOpenChecklist_Click(object sender, EventArgs e) => new ChecklistForm().ShowDialog();
        private void btnOpenStaffActivity_Click(object sender, EventArgs e) => new StaffActivityForm().ShowDialog();
        private void btnOpenSkills_Click(object sender, EventArgs e) => new ZookeeperSkillsForm().ShowDialog();
        private void btnOpenZoneCoverage_Click(object sender, EventArgs e) => new ZoneCoverageForm().ShowDialog();
        private void btnRecordFeeding_Click(object sender, EventArgs e) => new FeedingForm().ShowDialog();
        private void btnRecordCare_Click(object sender, EventArgs e) => new VetForm().ShowDialog();

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (AddStaffForm form = new AddStaffForm())
            {
                form.ShowDialog();
                LoadStaff();
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                DataRowView row = staffDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
                if (row != null)
                {
                    using (AddStaffForm form = new AddStaffForm(row.Row))
                    {
                        form.ShowDialog();
                        LoadStaff();
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
                DataRowView row = animalsDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
                if (row != null)
                {
                    using (AddAnimalForm form = new AddAnimalForm(row.Row))
                    {
                        form.ShowDialog();
                        LoadAnimals();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an animal to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // --------- Filters ---------
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

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            // Optional: implement animal search by name
        }

        private void btnAddEnclosure_Click_Click(object sender, EventArgs e)
        {
            using (var form = new AddEnclosureForm())
            {
                form.ShowDialog();
                LoadEnclosures(); // Refresh after add
            }
        }

        private void btnEditEnclosure_Click(object sender, EventArgs e)
        {
            if (enclosuresDataGridView.SelectedRows.Count > 0)
            {
                DataRowView rowView = enclosuresDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    using (var form = new AddEnclosureForm(rowView.Row))
                    {
                        form.ShowDialog();
                        LoadEnclosures(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an enclosure to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
