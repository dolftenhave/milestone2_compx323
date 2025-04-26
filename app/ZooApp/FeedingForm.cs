using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class FeedingForm : Form
    {
        public FeedingForm()
        {
            InitializeComponent();
        }

        private void FeedingForm_Load(object sender, EventArgs e)
        {
            // Dummy staff data
            string[,] staffData = new string[,]
            {
                { "101", "Mary", "Brown", "Vet" },
                { "102", "John", "Smith", "Zookeeper" },
                { "103", "Alice", "Green", "General Staff" },
                { "104", "Zane", "Taylor", "Zookeeper" }
            };

            // Dummy animal list
            string[] animals = { "Leo", "Tina", "Zara" };

            // Populate dropdowns
            for (int i = 0; i < staffData.GetLength(0); i++)
            {
                if (staffData[i, 3] == "Zookeeper")
                {
                    cbZookeeper.Items.Add($"{staffData[i, 1]} {staffData[i, 2]}");
                }
            }

            cbAnimal.Items.AddRange(animals);

            cbZookeeper.SelectedIndex = 0;
            cbAnimal.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string keeper = cbZookeeper.SelectedItem?.ToString();
            string animal = cbAnimal.SelectedItem?.ToString();
            string foodType = txtFoodType.Text.Trim();
            string amountText = txtAmount.Text.Trim();
            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;

            if (string.IsNullOrEmpty(keeper) || string.IsNullOrEmpty(animal) ||
                string.IsNullOrEmpty(foodType) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("Please complete all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(amountText, out double amount))
            {
                MessageBox.Show("Amount must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add insert to database logic here
            MessageBox.Show("Feeding record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
