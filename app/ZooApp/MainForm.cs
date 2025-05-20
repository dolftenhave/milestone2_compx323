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
            lblStaffName.Text = $"Welcome, {getStaffDetails()}";
            displayFeedingList();

            // for now, loading the animals at the same time. Will change this in future!
            populateAnimalComboBox();
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
            const int NUMBER_OF_ROWS = 6;

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

            DateTime currentTime = DateTime.Now;

            //Displays all the UI components
            for (int i = 0; i < animals.Rows.Count; i++)
            {
                //TODO load animals who do not have a last fed date
                if (!String.IsNullOrWhiteSpace(animals.Rows[i][3].ToString()))
                {
                    DateTime lastFed = (DateTime)animals.Rows[i][3];
                    TimeSpan hours = currentTime - lastFed;                   

                    int totalTime = (int)hours.TotalHours;
                    
                    makeTodoUiComponent_Feed(animals.Rows[i][1].ToString(), animals.Rows[i][2].ToString(), totalTime, int.Parse(animals.Rows[i][4].ToString()), i);
                }
                else
                {
                    makeTodoUiComponent_Feed(animals.Rows[i][1].ToString(), animals.Rows[i][2].ToString(), -1, int.Parse(animals.Rows[i][4].ToString()), i);
                }
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
        private void makeTodoUiComponent_Feed(String name, String speciesName, int totalTime, int FeedingInterval, int n)
        {
            String timeSuffix = " hours";
            String overDue = "";


            tabHome.Controls.IndexOfKey("lbl_home_animalName0");

            Label lblName = (Label)this.Controls.Find($"lbl_home_animalName{n}", true)[0];
            Label lblSpecies = (Label)this.Controls.Find($"lbl_home_animalSpecies{n}", true)[0];
            Label lblSinceFeed = (Label)this.Controls.Find($"lbl_home_timeSinceFeed{n}", true)[0];
            Label lblF = (Label)this.Controls.Find($"lbl_home_f{n}", true)[0];
            Button btnFeed = (Button)this.Controls.Find($"btn_home_feed{n}", true)[0];
            Panel panel = (Panel)this.Controls.Find($"panel_home_feeding{n}", true)[0];


            if (totalTime != -1)
            {
                if (totalTime > FeedingInterval)
                {
                    panel.BackColor = System.Drawing.Color.Pink;
                    totalTime -= FeedingInterval;
                    lblF.Text += "\nOverdue by:";
                    overDue = "!";
                }


                //Yes this is terribly ugly
                if (totalTime > 24)
                {
                    totalTime = (int)totalTime/24;
                    timeSuffix = " days";
                    if (totalTime > 365)
                    {
                        totalTime = totalTime / 365;
                        timeSuffix = "y";
                    }
                }

                lblSinceFeed.Text = totalTime.ToString() + timeSuffix + overDue;
            }
            else
            {
                lblSinceFeed.Text = "Never!";
                panel.BackColor = System.Drawing.Color.Pink;
            }


            lblF.Visible = true;

            lblName.Visible = true;
            lblName.Text = name;

            lblSpecies.Visible = true;
            lblSpecies.Text = speciesName;

            lblSinceFeed.Visible = true;
            

            btnFeed.Visible = true;
        }

        /// <summary>
        /// Get a DataTable of Animals that are relevant to the logged in Staff.
        /// 
        /// Don't like this query at the moment but it does the job for the small dataset.
        /// </summary>
        /// <returns>DataTable of Animals</returns>
        private DataTable getStaffAnimals()
        {
            String query = $"SELECT a.aid, a.name " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a " +
                $"WHERE a.aid IN " +
                $"(SELECT a1.aid " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a1, {DatabaseHelper.Table("SPECIESGROUP")} sg, " +
                $"{DatabaseHelper.Table("SPECIES")} sp, {DatabaseHelper.Table("OVERSEES")} o, {DatabaseHelper.Table("STAFF")} st " +
                $"WHERE st.sid = o.staffid " +
                $"AND o.sgroupname = sg.latinname " +
                $"AND sg.latinname = sp.speciesgroup " +
                $"AND sp.latinname = a1.speciesname " +
                $"AND st.sid = '{staffMemberId}')";

            DataTable staffAnimals = DatabaseHelper.ExecuteQuery(query);
            return staffAnimals;
        }

        /// <summary>
        /// Method for populating the animal combobox.
        /// </summary>
        private void populateAnimalComboBox()
        {
            DataTable queryResult = getStaffAnimals();
            cbSelectAnimal.Items.Clear();

            for (int i = 0; i < queryResult.Rows.Count; i++)
            {
                String toAdd = queryResult.Rows[i]["name"].ToString();
                cbSelectAnimal.Items.Add(toAdd);
            }

            return;
        }

        /// <summary>
        /// A helper method to get the age as a string, from a DateTime DateOfBirth.
        /// </summary>
        /// <returns>The age of the animal as a String.</returns>
        private String getAgeFromDob(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            // If the dob date is further along than the date today, then their last birthday did not happen
            if (dob.Date > today.AddYears(-age)) --age;

            return age.ToString();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAnimalForm().ShowDialog();
            this.Close();
        }

        private void cbSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the information for everything except latest feed/care
            // THIS DOES NOT TAKE INTO ACCOUNT THE ENCLOSURE NAME BEING ADDED IN FUTURE
            String animalName = cbSelectAnimal.SelectedItem.ToString();
            String queryGeneralInfo = $"SELECT a.aid, a.feedinginterval, s.commonname, a.dob, a.sex, e.eid, z.name " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("ZONE")} z, " +
                $"{DatabaseHelper.Table("ENCLOSURE")} e, {DatabaseHelper.Table("SPECIES")} s " +
                $"WHERE a.name = '{animalName}' " +
                $"AND a.enclosureid = e.eid " +
                $"AND e.zonename = z.name " +
                $"AND s.latinname = a.speciesname";

            // Extract this information
            DataTable animalData = DatabaseHelper.ExecuteQuery(queryGeneralInfo);
            if (animalData == null)
            {
                MessageBox.Show("Error in loading animal data: none selected");
                return;
            }

            // Get the aid for better querying in the following queries
            String aid = animalData.Rows[0]["aid"].ToString();

            String speciesName = animalData.Rows[0]["commonname"].ToString();
            String animalAge = getAgeFromDob(DateTime.Parse(animalData.Rows[0]["dob"].ToString()));
            String animalSex = animalData.Rows[0]["sex"].ToString();
            // To change to enclosure NAME
            String enclosureEID = animalData.Rows[0]["eid"].ToString();
            String zoneName = animalData.Rows[0]["name"].ToString();
            String feedingInterval = animalData.Rows[0]["feedinginterval"].ToString() + " Hours";

            String lastFed = "Never Fed!";
            String lastCared = "Never Cared!";

            String queryLastFeed = $"SELECT datetime " +
                $"FROM {DatabaseHelper.Table("FEED")} " +
                $"WHERE animalid = '{aid}' " +
                $"ORDER BY datetime DESC " +
                $"FETCH FIRST 1 ROWS ONLY";

            String queryLastCare = $"SELECT datetime " +
                $"FROM {DatabaseHelper.Table("CARE")} " +
                $"WHERE animalid = '{aid}' " +
                $"ORDER BY datetime DESC " +
                $"FETCH FIRST 1 ROWS ONLY";

            animalData = DatabaseHelper.ExecuteQuery(queryLastCare);
            if (animalData != null && animalData.Rows.Count != 0) lastCared = animalData.Rows[0]["datetime"].ToString();

            animalData = DatabaseHelper.ExecuteQuery(queryLastFeed);
            if (animalData != null && animalData.Rows.Count != 0) lastFed = animalData.Rows[0]["datetime"].ToString();


            // And set the textbox values
            txtSpecies.Text = speciesName;
            txtAge.Text = animalAge;
            txtSex.Text = animalSex;
            txtEnclosure.Text = enclosureEID;
            txtZone.Text = zoneName;
            txtLastCare.Text = lastCared;
            txtLastFed.Text = lastFed;
            txtFeedingInterval.Text = feedingInterval;
        }

        /// <summary>
        /// Method for populating the Zone UI with elements.
        /// </summary>
        private void populateZoneUIElements()
        {

        }

        private void resetZonePaging()
        {
            int NUM_ELEMENTS = 6;

            // If search box contains nothing, then search all.
            String countQuery;
            if (textBoxZoneSearch.Text != "")
            {
                countQuery = $"SELECT COUNT(*) " +
                $"FROM {DatabaseHelper.Table("ZONE")} " +
                $"WHERE name = '{textBoxZoneSearch.Text}' " +
                $"AND name IN (" +
                    $"SELECT z.name" +
                    $"FROM {DatabaseHelper.Table("ZONE")} z, {DatabaseHelper.Table("ENCLOSURE")} e, " +
                    $"{DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("SPECIES")} sp, " +
                    $"{DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("OVERSEES")} o " +
                    $"WHERE o.staff = '{staffMemberId}' " +
                    $"AND o.sgroupname = sg.latinname " +
                    $"AND sg.latinname = sp.speciesgroup " +
                    $"AND sp.latinname = a.speciesname " +
                    $"AND a.enclosureID = e.eid " +
                    $"AND e.zonename = z.name)";
            }
            else
            {
                countQuery = $"SELECT COUNT(*) AS \"count\"" +
                $"FROM {DatabaseHelper.Table("ZONE")} " +
                $"WHERE name IN (" +
                    $"SELECT z.name" +
                    $"FROM {DatabaseHelper.Table("ZONE")} z, {DatabaseHelper.Table("ENCLOSURE")} e, " +
                    $"{DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("SPECIES")} sp, " +
                    $"{DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("OVERSEES")} o " +
                    $"WHERE o.staff = '{staffMemberId}' " +
                    $"AND o.sgroupname = sg.latinname " +
                    $"AND sg.latinname = sp.speciesgroup " +
                    $"AND sp.latinname = a.speciesname " +
                    $"AND a.enclosureID = e.eid " +
                    $"AND e.zonename = z.name)";
            }

            DataTable countDt = DatabaseHelper.ExecuteQuery(countQuery);
            int totalCount = int.Parse(countDt.Rows[0]["count"].ToString());
            int numPages = (totalCount - 1 / NUM_ELEMENTS) + 1;
         
            NumericUpDown nud = this.numericUpDownZonePage;
            nud.Value = 1;
            nud.Maximum = numPages;
            nud.Minimum = 0;
            
        }

        /// <summary>
        /// Method for getting the Zones according to a search string.
        /// </summary>
        /// <param name="toSearch"></param>
        /// <returns></returns>
        private DataTable getZones(String toSearch = null)
        {
            String dataQuery = "";
            String countQuery = "";
            return null;
        }

        private void btnSelectZone_Click(object sender, EventArgs e)
        {
            return;
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

        /// <summary>
        /// This should be where data is loaded on demand for each tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            return;
            // 0 = Home
            // 1 = Animal
            // 2 = Enclosure
            // 3 = Zone
            int index = ((TabControl)sender).SelectedIndex;
            switch (index)
            {
                case 0:
                    // Can implement Home tab logic here
                    return;
                case 1:
                    // Animal Tab Logic
                    populateAnimalComboBox();
                    return;
                case 2:
                    // Can implement Enclosure tab logic here
                    return;
                case 3:
                    // Zone Tab Logic
                    populateZoneUIElements();
                    return;
                default:
                    return;

            }
        }
    }
}
