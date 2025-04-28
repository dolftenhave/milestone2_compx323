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
            if (!DatabaseHelper.ConnectToDatabase())
            {
                MessageBox.Show("Cannot connect to database. Application will exit.");
                Application.Exit();
                return;
            }

            cbZoneFilter.Items.AddRange(new string[] { "None", "Zone A", "Zone B", "Zone C" });
            cbEnclosureFilter.Items.AddRange(new string[] { "None", "E1", "E2", "E3" });
            cbBiomeFilter.Items.AddRange(new string[] { "None", "Savannah", "Rainforest", "Desert" });
            cbStaffRoleFilter.Items.AddRange(new string[] { "None", "Vet", "Zookeeper", "General Staff" });

            cbZoneFilter.SelectedIndex = 0;
            cbEnclosureFilter.SelectedIndex = 0;
            cbBiomeFilter.SelectedIndex = 0;
            cbStaffRoleFilter.SelectedIndex = 0;

            LoadAnimals();
            LoadEnclosures();
            LoadStaff();
            LoadCareFeeding();
        }

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

            try
            {
                string query = @"
                    SELECT A.AID, A.NAME, A.WEIGHT, A.ORIGINCOUNTRY, A.DOB, 
                           E.EID, Z.NAME
                    FROM M2S_ANIMAL A
                    LEFT JOIN M2S_ENCLOSURE E ON A.ENCLOSUREID = E.EID
                    LEFT JOIN M2S_ZONE Z ON E.ZONENAME = Z.NAME";

                using (OracleCommand cmd = new OracleCommand(query, DatabaseHelper.GetConnection()))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvAnimals.Rows.Add(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetString(3),
                                reader.GetDateTime(4).ToString("yyyy-MM-dd"),
                                reader.IsDBNull(5) ? "NULL" : reader.GetInt32(5).ToString(),
                                reader.IsDBNull(6) ? "Unknown" : reader.GetString(6)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading animals: " + ex.Message);
            }
        }

        private void LoadEnclosures()
        {
            dgvEnclosures.Rows.Clear();
            dgvEnclosures.Columns.Clear();

            dgvEnclosures.Columns.Add("EID", "Enclosure ID");
            dgvEnclosures.Columns.Add("Biome", "Biome");
            dgvEnclosures.Columns.Add("Zone", "Zone");

            try
            {
                string query = @"SELECT EID, BIOME, ZONENAME FROM M2S_ENCLOSURE";

                using (OracleCommand cmd = new OracleCommand(query, DatabaseHelper.GetConnection()))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvEnclosures.Rows.Add(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.IsDBNull(2) ? "Unknown" : reader.GetString(2)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading enclosures: " + ex.Message);
            }
        }

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

            try
            {
                string query = @"SELECT SID, FNAME, LNAME, EMAIL, PHNUMBER FROM M2S_STAFF";

                using (OracleCommand cmd = new OracleCommand(query, DatabaseHelper.GetConnection()))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvStaff.Rows.Add(
                                reader.GetInt32(0),
                                reader.GetString(1) + " " + reader.GetString(2),
                                "-", // No role info yet
                                reader.GetString(3),
                                reader.GetString(4),
                                "-", "-", "-" // No zone or animal info yet
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }

        private void LoadCareFeeding()
        {
            dgvCareFeeding.Rows.Clear();
            dgvCareFeeding.Columns.Clear();

            dgvCareFeeding.Columns.Add("Type", "Type");
            dgvCareFeeding.Columns.Add("Staff", "Staff ID");
            dgvCareFeeding.Columns.Add("Animal", "Animal ID");
            dgvCareFeeding.Columns.Add("Date", "Date");
            dgvCareFeeding.Columns.Add("Details", "Details");

            try
            {
                string careQuery = @"SELECT 'Care', STAFFID, ANIMALID, DATETIME, CARE FROM M2S_CARE
                                     UNION ALL
                                     SELECT 'Feeding', STAFFID, ANIMALID, DATETIME, FOODTYPE FROM M2S_FEED";

                using (OracleCommand cmd = new OracleCommand(careQuery, DatabaseHelper.GetConnection()))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvCareFeeding.Rows.Add(
                                reader.GetString(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetDateTime(3).ToString("yyyy-MM-dd HH:mm"),
                                reader.GetString(4)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading care/feeding: " + ex.Message);
            }
        }

        // Button Handlers
        private void btnRefreshAnimals_Click(object sender, EventArgs e) => LoadAnimals();
        private void btnRefreshEnclosures_Click(object sender, EventArgs e) => LoadEnclosures();
        private void btnRefreshStaff_Click(object sender, EventArgs e) => LoadStaff();
        private void btnRecordFeeding_Click(object sender, EventArgs e) => new FeedingForm().ShowDialog();
        private void btnRecordCare_Click(object sender, EventArgs e) => new VetForm().ShowDialog();
        private void btnAddAnimal_Click(object sender, EventArgs e) => new AddAnimalForm().ShowDialog();
        private void btnAddStaff_Click(object sender, EventArgs e) => new AddStaffForm().ShowDialog();
        private void btnOpenChecklist_Click(object sender, EventArgs e) => new ChecklistForm().ShowDialog();
        private void btnOpenStaffActivity_Click(object sender, EventArgs e) => new StaffActivityForm().ShowDialog();
        private void btnOpenSkills_Click(object sender, EventArgs e) => new ZookeeperSkillsForm().ShowDialog();
        private void btnOpenZoneCoverage_Click(object sender, EventArgs e) => new ZoneCoverageForm().ShowDialog();
        private void tabFeedingCare_Click(object sender, EventArgs e) => LoadCareFeeding();
    }
}
