using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class MainForm : Form
    {
        private Staff currentStaff;

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = $"Welcome, {currentStaff.Name}";

            if (currentStaff.IsZookeeper)
            {
                lvQualifiedSpecies.Visible = true;
                lvFeedRecords.Visible = true;
                btnAddFeed.Visible = true;

                lvCaredAnimals.Visible = false;
                lvCareRecords.Visible = false;
                btnAddCare.Visible = false;
            }
            else if (currentStaff.IsVet)
            {
                lvQualifiedSpecies.Visible = false;
                lvFeedRecords.Visible = false;
                btnAddFeed.Visible = false;

                lvCaredAnimals.Visible = true;
                lvCareRecords.Visible = true;
                btnAddCare.Visible = true;
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAnimalForm().ShowDialog();
            this.Close();
        }

        private void cbSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Leave empty for now
        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            // Placeholder for feed logic
        }

        private void btnAddCare_Click(object sender, EventArgs e)
        {
            // Placeholder for care logic
        }
        private void cbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Load enclosures in selected zone
        }

        private void cbEnclosure_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Load animals in selected enclosure
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Add new enclosure or animal (could open a form)
        }

    }
}
