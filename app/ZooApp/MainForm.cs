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
        private int staffRole; //0 for ZooKeeper and  for Vet
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
            displayFeedingList();
        }

        /**<summary>
         * Gets the first name of the staff member that is displayed in the welcome text at the top of the screen
         * @author Dolf ten Have
         * </summary>
         */
        private String getStaffDetails()
        {
            String Query = $"SELECT fname, clinic FROM {DatabaseHelper.Table("STAFF")} WHERE sid = {staffMemberId}";
            DataTable dt = DatabaseHelper.ExecuteQuery(Query);

            if (dt.Rows[0][1].ToString() == "")
                staffRole = 1;
            else
                staffRole= 0;

            return dt.Rows[0][0].ToString();
        }

        /**<summary>
         * Gets the list of all animals that will be fed by this staffMember
         * @author Dolf ten Have
         * </summary>
         * <returns>A DataTable containg information about the animals that that person can feed</returns>
         */
        private DataTable getFeedingList()
        {
            const int NUMBER_OF_ROWS = 9;

            String query2 = $"SELECT a.aid, a.name, s3.commonName, f.datetime , a.feedingInterval FROM m2s_animal a LEFT OUTER JOIN m2s_Feed f ON a.aid = f.animalid LEFT OUTER JOIN m2s_Species s3 ON a.speciesName = s3.latinName WHERE a.aid IN (SELECT a2.aid FROM m2s_Staff s2 LEFT OUTER JOIN m2s_oversees o2 ON s2.SID = o2.staffID JOIN m2s_SpeciesGroup sg2 ON o2.sGroupName = sg2.latinName JOIN m2s_Species s2 ON s2.speciesGroup = sg2.latinName JOIN m2s_Animal a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {staffMemberId}) AND f.dateTime = (SELECT MAX(dateTime) FROM m2s_feed f2 WHERE a.aid = f2.animalid) OR a.aid NOT IN (SELECT DISTINCT animalID FROM m2s_FEED) ORDER BY f.dateTime ASC NULLS FIRST FETCH FIRST 5 ROWS ONLY";

            String query = $"SELECT a.aid, a.name, s3.commonName, f.datetime, a.feedingInterval " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("FEED")} f ON a.aid = f.animalid " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("SPECIES")} s3 ON a.speciesName = s3.latinName " +
                $"WHERE a.aid IN " +
                $"(SELECT a2.aid FROM {DatabaseHelper.Table("STAFF")} s2 " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("OVERSEES")} o2 ON s2.SID = o2.staffID " +
                $"JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg2 ON o2.sGroupName = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("SPECIES")} s2 ON s2.speciesGroup = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("ANIMAL")} a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {staffMemberId}) " +
                $"AND f.dateTime = (SELECT MAX(dateTime) FROM {DatabaseHelper.Table("FEED")} f2 WHERE a.aid = f2.animalid) " +
                $"OR a.aid NOT IN (SELECT DISTINCT animalID FROM {DatabaseHelper.Table("FEED")})" +
                $"ORDER BY f.dateTime ASC NULLS FIRST " +
                $"FETCH FIRST {NUMBER_OF_ROWS} ROWS ONLY";

            DataTable animals = DatabaseHelper.ExecuteQuery(query);
            return animals;
        }

        /**<summary>
         * Displays the list of animals that need feeding on the home page
         * 
         * @author Dolf ten Have
         * </summary>
         */
        private void displayFeedingList()
        {
            DataTable animals = getFeedingList();

            if (staffRole == 0)
                groupBoxTODO.Text = "Feeding List:";
            else
                groupBoxTODO.Text = "Checkup List:";

            //If there are no animals that this person has/can feed then a message is displayed to the user.
            if(animals.Rows.Count < 1) { 
                Label lbl = new Label();
                lbl.Text = "There are no Animals that you need to feed.";
                lbl.AutoSize= true;
                lbl.Location = new System.Drawing.Point(groupBoxTODO.Location.X + 10, groupBoxTODO.Location.Y + 10 + lbl.Height);
                groupBoxTODO.Controls.Add(lbl);
                return;
            }

            //Displays all the UI components
            for(int i = 0; i < animals.Rows.Count; i++)
            {
                //DateTime lastFed = (DateTime)animals.Rows[i][3];
                //makeTodoUiComponent_Feed(animals.Rows[i][1].ToString(), animals.Rows[i][2].ToString(), lastFed, int.Parse(animals.Rows[i][4].ToString()), i);
            }
        }

        /**<summary>
         * Creates a UI component for each entry that is returned to the page
         * 
         * @author Dolf ten Have
         * </summary>
         * <param name="name">The name of the Animal</param>
         * <param name="speciesName">The species Name of the Animal</param>
         * <param name="lastFed">A timestamp of when the animal was last fed</param>
         * <param name="FeedingInterval">The feeding interval of the animal</param>
         * <param name="n">The row number that this control was generated from</param>
         */
        private void makeTodoUiComponent_Feed(String name, String speciesName, DateTime lastFed, int FeedingInterval, int n)
        {
            Panel p = new Panel();
            Label lName = new Label();
            Label lSpeciesName = new Label();
            Label lblLastFed = new Label();

            DateTime currentTime = DateTime.Now;

            TimeSpan hours = currentTime - lastFed;

            int totalHours = (int)hours.TotalHours;

            lblLastFed.Text = totalHours.ToString();
                

            lName.Text = name;
            System.Drawing.Font font = new System.Drawing.Font(Label.DefaultFont.FontFamily, 15, Label.DefaultFont.Style);
            lName.Font = font;
            lName.AutoSize = true;
            lName.Location = new System.Drawing.Point(p.Location.X, p.Location.Y + 2);

            lSpeciesName.Text = speciesName;
            lSpeciesName.AutoSize = true;
            lSpeciesName.Location = new System.Drawing.Point(p.Location.X, lName.Location.Y + lName.Height);

            p.Width = groupBoxTODO.Width;
            p.Height= groupBoxTODO.Height / 10;

            groupBoxTODO.Controls.Add(p);
            p.Controls.Add(lName);
            p.Controls.Add(lSpeciesName);
            p.Location = new System.Drawing.Point(groupBoxTODO.Location.X, groupBoxTODO.Location.Y + 2 + (p.Height * n));
            p.BackColor = System.Drawing.Color.Pink;

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
