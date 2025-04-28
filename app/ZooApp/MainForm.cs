using System;
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

            OracleHelper.ConnectionString = "Data Source=...;User Id=...;Password=...";
            OracleHelper.Connect();

            // Populate filters
            cbZoneFilter.Items.AddRange(new string[] { "None", "Zone A", "Zone B", "Zone C" });
            cbEnclosureFilter.Items.AddRange(new string[] { "None", "E1", "E2", "E3" });
            cbBiomeFilter.Items.AddRange(new string[] { "None", "Savannah", "Rainforest", "Desert" });
            cbStaffRoleFilter.Items.AddRange(new string[] { "None", "Vet", "Zookeeper", "General Staff" });

            cbZoneFilter.SelectedIndex = 0;
            cbEnclosureFilter.SelectedIndex = 0;
            cbBiomeFilter.SelectedIndex = 0;
            cbStaffRoleFilter.SelectedIndex = 0;

            // Load data
            LoadAnimals();
            LoadEnclosures();
            LoadStaff();
            LoadCareFeeding();
        }

        // ----------------- Animals -----------------
        private void LoadAnimals()
        {
            dgvAnimals.Rows.Clear();
            dgvAnimals.Columns.Clear();

            dgvAnimals.Columns.Add("ID", "Animal ID");
            dgvAnimals.Columns.Add("Name", "Name");
            dgvAnimals.Columns.Add("Weight", "Weight");
            dgvAnimals.Columns.Add("OriginCountry", "Origin Country");
            dgvAnimals.Columns.Add("DOB", "Date of Birth");
            dgvAnimals.Columns.Add("Enclosure", "Enclosure ID");
            dgvAnimals.Columns.Add("Zone", "Zone");

            var data = new[]
            {
                new object[] { "A1", "Leoaa", 150, "Kenya", "2020-01-01", "E1", "Zone A" },
                new object[] { "A2", "Tinaaa", 180, "India", "2019-05-12", "E2", "Zone B" },
                new object[] { "A3", "Zaraaa", 120, "South Africa", "2021-03-15", "E1", "Zone A" }
            };

            string selectedZone = cbZoneFilter.SelectedItem.ToString();
            string selectedEnclosure = cbEnclosureFilter.SelectedItem.ToString();

            foreach (var row in data)
            {
                bool matchesZone = (selectedZone == "None" || (row[6] as string) == selectedZone);
                bool matchesEnclosure = (selectedEnclosure == "None" || (row[5] as string) == selectedEnclosure);

                if (matchesZone && matchesEnclosure)
                {
                    dgvAnimals.Rows.Add(row);
                }
            }
        }

        // ----------------- Enclosures -----------------
        private void LoadEnclosures()
        {
            dgvEnclosures.Rows.Clear();
            dgvEnclosures.Columns.Clear();

            dgvEnclosures.Columns.Add("EID", "Enclosure ID");
            dgvEnclosures.Columns.Add("Biome", "Biome");
            dgvEnclosures.Columns.Add("Zone", "Zone");
            dgvEnclosures.Columns.Add("Animals", "Animals");

            var data = new[]
            {
                new object[] { "E1", "Savannah", "Zone A", "Leoaa, Zaraaa" },
                new object[] { "E2", "Rainforest", "Zone B", "Tinaaa" },
                new object[] { "E3", "Desert", "Zone C", "-" }
            };

            string selectedBiome = cbBiomeFilter.SelectedItem.ToString();

            foreach (var row in data)
            {
                if (selectedBiome == "None" || (row[1] as string) == selectedBiome)
                {
                    dgvEnclosures.Rows.Add(row);
                }
            }
        }

        // ----------------- Staff -----------------
        private void LoadStaff()
        {
            dgvStaff.Rows.Clear();
            dgvStaff.Columns.Clear();

            dgvStaff.Columns.Add("SID", "Staff ID");
            dgvStaff.Columns.Add("Name", "Full Name");
            dgvStaff.Columns.Add("Role", "Role");
            dgvStaff.Columns.Add("Email", "Email");
            dgvStaff.Columns.Add("Phone", "Phone");
            dgvStaff.Columns.Add("Zone", "Assigned Zone(s)");
            dgvStaff.Columns.Add("Animals", "Animals Caring For");

            var data = new[]
            {
                new object[] { "S1", "John Smith", "Zookeeper", "john@zoo.com", "123456", "Zone A, Zone B", "Leoaa, Zaraaa" },
                new object[] { "S2", "Mary Brown", "Vet", "mary@zoo.com", "654321", "Zone B", "Tinaaa" },
                new object[] { "S3", "Alice Green", "General Staff", "alice@zoo.com", "112233", "Zone C", "-" }
            };

            string selectedRole = cbStaffRoleFilter.SelectedItem.ToString();

            foreach (var row in data)
            {
                if (selectedRole == "None" || (row[2] as string) == selectedRole)
                {
                    dgvStaff.Rows.Add(row);
                }
            }
        }

        // ----------------- Feeding / Care -----------------
        private void LoadCareFeeding()
        {
            dgvCareFeeding.Rows.Clear();
            dgvCareFeeding.Columns.Clear();

            dgvCareFeeding.Columns.Add("Type", "Type");
            dgvCareFeeding.Columns.Add("Staff", "Staff");
            dgvCareFeeding.Columns.Add("Animal", "Animal");
            dgvCareFeeding.Columns.Add("Date", "Date");
            dgvCareFeeding.Columns.Add("Details", "Details");

            var data = new[]
            {
                new object[] { "Feeding", "John Smith", "Leoaa", "2025-04-25", "5kg beef, 10:00AM" },
                new object[] { "Care", "Mary Brown", "Tinaaa", "2025-04-25", "Annual checkup, vaccination" }
            };

            foreach (var row in data)
            {
                dgvCareFeeding.Rows.Add(row);
            }
        }

        // Button Event Handlers
        private void btnRefreshAnimals_Click(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void btnRefreshEnclosures_Click(object sender, EventArgs e)
        {
            LoadEnclosures();
        }

        private void btnRefreshStaff_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void btnRecordFeeding_Click(object sender, EventArgs e)
        {
            FeedingForm feedingForm = new FeedingForm();
            feedingForm.ShowDialog();
            LoadCareFeeding();
        }

        private void btnRecordCare_Click(object sender, EventArgs e)
        {
            VetForm vetForm = new VetForm();
            vetForm.ShowDialog();
            LoadCareFeeding();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            addAnimalForm.ShowDialog();
            LoadAnimals();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            LoadStaff();
        }

        private void btnOpenChecklist_Click(object sender, EventArgs e)
        {
            ChecklistForm checklistForm = new ChecklistForm();
            checklistForm.ShowDialog();
        }

        private void btnOpenStaffActivity_Click(object sender, EventArgs e)
        {
            StaffActivityForm staffActivityForm = new StaffActivityForm();
            staffActivityForm.ShowDialog();
        }

        private void btnOpenSkills_Click(object sender, EventArgs e)
        {
            ZookeeperSkillsForm skillsForm = new ZookeeperSkillsForm();
            skillsForm.ShowDialog();
        }

        private void btnOpenZoneCoverage_Click(object sender, EventArgs e)
        {
            ZoneCoverageForm zoneForm = new ZoneCoverageForm();
            zoneForm.ShowDialog();
        }

        private void tabFeedingCare_Click(object sender, EventArgs e)
        {
            LoadCareFeeding();
        }
    }
}
