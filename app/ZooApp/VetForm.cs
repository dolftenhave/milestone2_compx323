using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class VetForm : Form
    {
        public VetForm()
        {
            InitializeComponent();
        }

        private void VetForm_Load(object sender, EventArgs e)
        {
            // Dummy staff and animal data
            string[,] staffData = new string[,]
            {
                { "101", "Mary", "Brown", "Vet" },
                { "102", "John", "Smith", "Zookeeper" },
                { "103", "Alice", "Green", "General Staff" },
                { "104", "Zane", "Taylor", "Zookeeper" }
            };

            string[] animals = { "Leo", "Tina", "Zara" };

            // Populate Vet dropdown
            for (int i = 0; i < staffData.GetLength(0); i++)
            {
                if (staffData[i, 3] == "Vet")
                {
                    cbVet.Items.Add($"{staffData[i, 1]} {staffData[i, 2]}"); // e.g., "Mary Brown"
                }
            }

            // Populate Animal dropdown
            cbAnimal.Items.AddRange(animals);

            cbVet.SelectedIndex = 0;
            cbAnimal.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string vet = cbVet.SelectedItem?.ToString();
            string animal = cbAnimal.SelectedItem?.ToString();
            string careType = txtCareType.Text.Trim();
            string notes = txtNotes.Text.Trim();
            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;

            if (string.IsNullOrEmpty(vet) || string.IsNullOrEmpty(animal) || string.IsNullOrEmpty(careType))
            {
                MessageBox.Show("Please complete all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            MessageBox.Show("Animal health activity recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
