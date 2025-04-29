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

        private void LoadAnimals(string filter = "")
        {
            string query = $"SELECT * FROM {DatabaseHelper.Table("ANIMAL")}";

            if (!string.IsNullOrWhiteSpace(filter))
            {
                query += $" WHERE LOWER(NAME) LIKE '%{filter.ToLower()}%'";
            }

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            animalsDataGridView.DataSource = dt;
        }

        private void btnSearchAnimal_Click_1(object sender, EventArgs e)
        {
            string searchTerm = txtAnimalSearch.Text.Trim();
            LoadAnimals(searchTerm);
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

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            var form = new AddAnimalForm();
            form.ShowDialog();
            LoadAnimals(); // Refresh list after add
        }

        private void btnAddEnclosure_Click(object sender, EventArgs e)
        {
            new AddEnclosureForm().ShowDialog();
            LoadEnclosures();  // Refresh after closing
        }

    }
}
