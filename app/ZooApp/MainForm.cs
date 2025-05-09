using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class MainForm : Form
    {
        // Variables to allow paging through large datasets.
        // Could potentially be moved to another class that manages state.
        private const int PAGE_SIZE = 50;
        private int
            animalDataTablePos,
            enclosureDataTablePos,
            staffDataTablePos,
            feedingCareDataTablePos,
            rolesDataTablePos;
        private DataTable
            animalsDt,
            enclosureDt,
            staffDt,
            feedingCareDt,
            rolesDt;

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
            txtAnimalSearch.Text = "Search Animal here";
            txtAnimalSearch.ForeColor = Color.Gray;
        }

        // --------- Loaders ---------
        private void LoadAnimals(string nameFilter = "")
        {
            try
            {
                string query = $@"
                    SELECT 
                        a.aid,
                        a.name,
                        a.sex,
                        a.dob,
                        a.weight,
                        a.feedingInterval,
                        a.originCountry,
                        a.enclosureID,
                        e.biome,
                        e.zoneName,
                        a.speciesName,
                        sg.commonName AS speciesGroup
                    FROM {DatabaseHelper.Table("ANIMAL")} a
                    LEFT JOIN {DatabaseHelper.Table("ENCLOSURE")} e ON a.enclosureID = e.eid
                    LEFT JOIN {DatabaseHelper.Table("SPECIES")} s ON a.speciesName = s.latinName
                    LEFT JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg ON s.speciesGroup = sg.latinName
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(nameFilter))
                {
                    query += $" AND LOWER(a.name) LIKE '%{nameFilter.ToLower()}%'";
                }

                animalsDt = DatabaseHelper.ExecuteQuery(query);
                animalsDataGridView.AutoGenerateColumns = true;
                animalsDataGridView.DataSource = GetDataTableSubset(animalsDt, 0, PAGE_SIZE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading animals: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to get a subset of a DataTable, e.g. Rows 50-100, returned as a new DataTable.
        /// 
        /// TODO: Error Checking on edge cases
        /// </summary>
        /// <param name="dt">The DataTable to take the subset from.</param>
        /// <param name="start">The starting index, inclusive</param>
        /// <param name="end">The ending index, exclusive</param>
        /// <returns></returns>
        private DataTable GetDataTableSubset(DataTable dt, int start, int end)
        {
            DataTable returnDt = dt.Clone();
            for (int i = start; i < end; i++)
            {
                DataRow row = dt.Rows[i];
                returnDt.Rows.Add(row.ItemArray);
            }
            return returnDt;
        }

        private void LoadEnclosures()
        {
            string query = $"SELECT e.eid, e.biome, e.esize, z.name AS zoneName " +
                           $"FROM {DatabaseHelper.Table("ENCLOSURE")} e " +
                           $"JOIN {DatabaseHelper.Table("ZONE")} z ON e.zoneName = z.name";

            enclosureDt = DatabaseHelper.ExecuteQuery(query);
            enclosuresDataGridView.DataSource = GetDataTableSubset(enclosureDt, 0, PAGE_SIZE);
            
            PopulateBiomeFilter(); // include this here
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

            staffDt = DatabaseHelper.ExecuteQuery(query);
            staffDataGridView.AutoGenerateColumns = true;
            staffDataGridView.DataSource = GetDataTableSubset(staffDt, 0, PAGE_SIZE);
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

            feedingCareDt = DatabaseHelper.ExecuteQuery(query);
            feedingDataGridView.AutoGenerateColumns = true;
            feedingDataGridView.DataSource = GetDataTableSubset(feedingCareDt, 0, PAGE_SIZE);
        }

        private void LoadRoles()
        {
            string query = $"SELECT DISTINCT clinic FROM {DatabaseHelper.Table("STAFF")}";
            rolesDt = DatabaseHelper.ExecuteQuery(query);

            cbStaffRoleFilter.Items.Clear();
            cbStaffRoleFilter.Items.Add("All");

            foreach (DataRow row in rolesDt.Rows)
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
            string searchName = txtAnimalSearch.Text.Trim();
            LoadAnimals(searchName);
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

        private void btnZoneCoverage_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member first.", "No Staff Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv = staffDataGridView.SelectedRows[0].DataBoundItem as DataRowView;
            if (drv == null) return;

            int sid = Convert.ToInt32(drv["sid"]);
            new ZoneCoverageForm(sid).ShowDialog();
        }

        private void txtAnimalSearch_Enter(object sender, EventArgs e)
        {
            if (txtAnimalSearch.Text == "Search Animal here")
            {
                txtAnimalSearch.Text = "";
                txtAnimalSearch.ForeColor = Color.Black;
            }
        }

        private void txtAnimalSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnimalSearch.Text))
            {
                txtAnimalSearch.Text = "Search Animal here";
                txtAnimalSearch.ForeColor = Color.Gray;
            }
        }

        private void btnRefreshAnimals_Click_1(object sender, EventArgs e)
        {
            txtAnimalSearch.Text = "Search Animal here";
            txtAnimalSearch.ForeColor = Color.Gray;
            LoadAnimals(); 
        }


        private void btnSearchEnclosures_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchEnclosure.Text.Trim().ToLower();
            string selectedBiome = cbBiomeFilter.SelectedItem?.ToString();

            string query = $"SELECT e.eid, e.biome, e.esize, z.name AS zoneName " +
                           $"FROM {DatabaseHelper.Table("ENCLOSURE")} e " +
                           $"JOIN {DatabaseHelper.Table("ZONE")} z ON e.zoneName = z.name " +
                           $"WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query += $"AND (LOWER(e.biome) LIKE '%{searchText}%' OR LOWER(z.name) LIKE '%{searchText}%') ";
            }

            if (!string.IsNullOrWhiteSpace(selectedBiome) && selectedBiome != "All")
            {
                query += $"AND e.biome = '{selectedBiome}' ";
            }

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            enclosuresDataGridView.DataSource = dt;
        }
        private void PopulateBiomeFilter()
        {
            string query = $"SELECT DISTINCT biome FROM {DatabaseHelper.Table("ENCLOSURE")}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cbBiomeFilter.Items.Clear();
            cbBiomeFilter.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                cbBiomeFilter.Items.Add(row["biome"].ToString());
            }

            cbBiomeFilter.SelectedIndex = 0;
        }

        private void btnRefreshEnclosures_Click_1(object sender, EventArgs e)
        {
            txtSearchEnclosure.Clear();
            cbBiomeFilter.SelectedIndex = 0;
            LoadEnclosures();
        }
    }
}
