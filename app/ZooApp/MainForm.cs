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
        }

        private void LoadAnimals()
        {
            string query = "SELECT * FROM M2S_ANIMAL";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            animalsDataGridView.DataSource = dt;
        }



        private void LoadEnclosures()
        {
            string query = "SELECT * FROM M2S_ENCLOSURE";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            enclosuresDataGridView.DataSource = dt;
        }


        private void LoadStaff()
        {
            string query = "SELECT * FROM M2S_STAFF";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            staffDataGridView.DataSource = dt;
        }


        private void LoadFeedings()
        {
            string query = "SELECT * FROM M2S_CARE";  // or "M2S_FEED" if you prefer feeding records
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            feedingDataGridView.DataSource = dt;
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
    }
}
