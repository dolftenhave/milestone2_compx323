using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class MainForm : Form
    {
        // Data for all tables
        private List<object[]> animalData;
        private List<object[]> enclosureData;
        private List<object[]> staffData;
        private List<object[]> careFeedingData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate filters
            cbZoneFilter.Items.AddRange(new string[] { "None", "Zone A", "Zone B", "Zone C" });
            cbEnclosureFilter.Items.AddRange(new string[] { "None", "E1", "E2", "E3" });
            cbBiomeFilter.Items.AddRange(new string[] { "None", "Savannah", "Rainforest", "Desert" });
            cbStaffRoleFilter.Items.AddRange(new string[] { "None", "Vet", "Zookeeper", "General Staff" });

            cbZoneFilter.SelectedIndex = 0;
            cbEnclosureFilter.SelectedIndex = 0;
            cbBiomeFilter.SelectedIndex = 0;
            cbStaffRoleFilter.SelectedIndex = 0;

            // Attach filter change events
            cbZoneFilter.SelectedIndexChanged += cbZoneFilter_SelectedIndexChanged;
            cbEnclosureFilter.SelectedIndexChanged += cbEnclosureFilter_SelectedIndexChanged;
            cbBiomeFilter.SelectedIndexChanged += cbBiomeFilter_SelectedIndexChanged;
            cbStaffRoleFilter.SelectedIndexChanged += cbStaffRoleFilter_SelectedIndexChanged;

            // Initialize Dummy Data
            InitializeData();

            // Load all views
            LoadAnimals();
            LoadEnclosures();
            LoadStaff();
            LoadCareFeeding();
        }

        private void InitializeData()
        {
            animalData = new List<object[]>
            {
                new object[] { "A1", "Leoaa", 150, "Kenya", "2020-01-01", "E1", "Zone A" },
                new object[] { "A2", "Tinaaa", 180, "India", "2019-05-12", "E2", "Zone B" },
                new object[] { "A3", "Zaraaa", 120, "South Africa", "2021-03-15", "E1", "Zone A" }
            };

            enclosureData = new List<object[]>
            {
                new object[] { "E1", "Savannah", "Zone A" },
                new object[] { "E2", "Rainforest", "Zone B" },
                new object[] { "E3", "Desert", "Zone C" }
            };

            staffData = new List<object[]>
            {
                new object[] { "S1", "John Smith", "Zookeeper", "john@zoo.com", "123456", "Zone A, Zone B", "Leoaa, Zaraaa" },
                new object[] { "S2", "Mary Brown", "Vet", "mary@zoo.com", "654321", "Zone B", "Tinaaa" },
                new object[] { "S3", "Alice Green", "General Staff", "alice@zoo.com", "112233", "Zone C", "-" }
            };

            careFeedingData = new List<object[]>
            {
                new object[] { "Feeding", "John Smith", "Leoaa", "2025-04-25", "5kg beef, 10:00AM" },
                new object[] { "Care", "Mary Brown", "Tinaaa", "2025-04-25", "Annual checkup, vaccination" }
            };
        }

        // Animals
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

            string selectedZone = cbZoneFilter.SelectedItem.ToString();
            string selectedEnclosure = cbEnclosureFilter.SelectedItem.ToString();

            foreach (var row in animalData)
            {
                bool matchesZone = (selectedZone == "None" || (string)row[6] == selectedZone);
                bool matchesEnclosure = (selectedEnclosure == "None" || (string)row[5] == selectedEnclosure);

                if (matchesZone && matchesEnclosure)
                {
                    dgvAnimals.Rows.Add(row);
                }
            }
        }

        // Enclosures
        private void LoadEnclosures()
        {
            dgvEnclosures.Rows.Clear();
            dgvEnclosures.Columns.Clear();

            dgvEnclosures.Columns.Add("EID", "Enclosure ID");
            dgvEnclosures.Columns.Add("Biome", "Biome");
            dgvEnclosures.Columns.Add("Zone", "Zone");
            dgvEnclosures.Columns.Add("Animals", "Animals Inside");

            string selectedBiome = cbBiomeFilter.SelectedItem.ToString();

            foreach (var enclosure in enclosureData)
            {
                string enclosureId = (string)enclosure[0];
                string biome = (string)enclosure[1];
                string zone = (string)enclosure[2];

                bool matchesBiome = (selectedBiome == "None" || biome == selectedBiome);

                if (matchesBiome)
                {
                    var animals = animalData
                        .Where(a => (string)a[5] == enclosureId)
                        .Select(a => (string)a[1])
                        .ToList();

                    string animalList = (animals.Count > 0) ? string.Join(", ", animals) : "-";

                    dgvEnclosures.Rows.Add(enclosureId, biome, zone, animalList);
                }
            }
        }

        // Staff
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

            string selectedRole = cbStaffRoleFilter.SelectedItem.ToString();

            foreach (var row in staffData)
            {
                bool matchesRole = (selectedRole == "None" || (string)row[2] == selectedRole);

                if (matchesRole)
                {
                    dgvStaff.Rows.Add(row);
                }
            }
        }

        // Feeding / Care
        private void LoadCareFeeding()
        {
            dgvCareFeeding.Rows.Clear();
            dgvCareFeeding.Columns.Clear();

            dgvCareFeeding.Columns.Add("Type", "Type");
            dgvCareFeeding.Columns.Add("Staff", "Staff");
            dgvCareFeeding.Columns.Add("Animal", "Animal");
            dgvCareFeeding.Columns.Add("Date", "Date");
            dgvCareFeeding.Columns.Add("Details", "Details");

            foreach (var row in careFeedingData)
            {
                dgvCareFeeding.Rows.Add(row);
            }
        }

        // Button Events
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            new AddAnimalForm().ShowDialog();
            LoadAnimals();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            new AddStaffForm().ShowDialog();
            LoadStaff();
        }

        private void btnRecordCare_Click(object sender, EventArgs e)
        {
            new VetForm().ShowDialog();
            LoadCareFeeding();
        }

        private void btnRecordFeeding_Click(object sender, EventArgs e)
        {
            new FeedingForm().ShowDialog();
            LoadCareFeeding();
        }

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

        private void tabFeedingCare_Click(object sender, EventArgs e)
        {
            LoadCareFeeding();
        }

        private void cbZoneFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void cbEnclosureFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void cbBiomeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEnclosures();
        }

        private void cbStaffRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
