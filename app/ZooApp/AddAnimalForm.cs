using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            // TODO: Populate species and enclosure from database
            cbSpecies.Items.AddRange(new string[] { "Lion", "Tiger", "Zebra" });
            cbEnclosure.Items.AddRange(new string[] { "E1", "E2", "E3" });

            cbSpecies.SelectedIndex = 0;
            cbSex.SelectedIndex = 0;
            cbEnclosure.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string animalName = txtAnimalName.Text.Trim();
            string species = cbSpecies.SelectedItem?.ToString();
            string sex = cbSex.SelectedItem?.ToString();
            string enclosure = cbEnclosure.SelectedItem?.ToString();
            DateTime dob = dtpDOB.Value;
            int feedingInterval;
            double weight;
            string country = txtCountry.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(species) || string.IsNullOrEmpty(sex) ||
                string.IsNullOrEmpty(enclosure) || string.IsNullOrEmpty(country) ||
                !int.TryParse(txtFeedingInterval.Text, out feedingInterval) ||
                !double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Please fill all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            MessageBox.Show("Animal Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
