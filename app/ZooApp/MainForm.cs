using System;
using System.Data;
using System.Windows.Forms;

/**<summary>
 * This is the main page of the application. Giving staff members access to everything they may need to do in the zoo
 * </summary>
 */
namespace ZooApp
{
    public partial class MainForm : Form
    {
        // The ID of the staff member currently looking at this page. All info will be relevent to them
        private int staffMemberId;
        private int staffRole; // 0 for zookeeper and 1 for vet
        public MainForm(int staffMemberId)
        {
            this.staffMemberId = staffMemberId;
            InitializeComponent();
        }

        /**<summary>
         * Loads staff and a list of animals needed to start the main form.
         * </summary>
         */
        private void MainForm_Load(object sender, EventArgs e) { 
            lblStaffNameWelcome.Text = $"Welcome, {getStaffDetails()}";
            //Get the names of all the animals that need to be fed
        }

        /**<summary>
         * Gets the first name of the staff member that is displayed in the welcome text at the top of the screen
         * @author Dolf ten Have
         * </summary>
         */
        private String getStaffDetails()
        {
            String name;
            String Query = $"SELECT fname, clinic FROM {DatabaseHelper.Table("STAFF")} WHERE sid = {staffMemberId}";
            DataTable dt = DatabaseHelper.ExecuteQuery(Query);

            MessageBox.Show(dt.Rows[0][1].ToString());
            return dt.Rows[0][0].ToString();
        }

        /**<summary>
         * Gets the list of all animals that will be fed by this staffMember
         * </summary>
         */
        private void getFeedingList()
        {


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
