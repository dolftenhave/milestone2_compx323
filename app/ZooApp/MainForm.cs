using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

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
        private int staffRole; //0 for ZooKeeper and 1 for Vet
        private int currentEnclosure; // -1 if no enclosure is selected
        private List<int> selectedAnimals; //A list of animals currently selected
        private List<CheckBox> selectedAnimalsCheckboxList; //contains a list of all checkboxes in the list so that it is easier to select and deselect all of them
        private List<int> EnclosureIdList; //Contains a list of id's of all the enclosures that have currently been searched for.


        public MainForm(int staffMemberId)
        {
            currentEnclosure = -1;
            this.staffMemberId = staffMemberId;
            selectedAnimals= new List<int>();
            selectedAnimalsCheckboxList= new List<CheckBox>();
            EnclosureIdList= new List<int>();
            InitializeComponent();
        }

        /**<summary>
         * Loads staff and a list of animals needed to start the main form.
         * </summary>
         */
        private void MainForm_Load(object sender, EventArgs e) {
            lblStaffName.Text = $"Welcome, {getStaffDetails()}";
            if(staffRole == 0)
                displayFeedingList();
            else
                groupBoxTODO.Text = "Checkup List:";
            //Load all the caring information
            // move the groupbox to the load method

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
                staffRole = 0;
            else
                staffRole= 1;

            return dt.Rows[0][0].ToString();
        }

        /**<summary>
         * Gets the list of all animals that this staff member is qualified to feed and have previously been feed at least once.
         * @author Dolf ten Have.
         * </summary>
         * <param name="rows">The maximum number of rows returned.</param>
         * <param name="staffID">The id of the staff member.</param>
         * <returns>A DataTable containg information about the animals that that person can feed.</returns>
         */
        private DataTable getFeedingListForStaff(int rows, int staffID)
        {
            //String query2 = $"SELECT a.aid, a.name, s3.commonName, f.datetime , a.feedingInterval FROM m2s_animal a LEFT OUTER JOIN m2s_Feed f ON a.aid = f.animalid LEFT OUTER JOIN m2s_Species s3 ON a.speciesName = s3.latinName WHERE a.aid IN (SELECT a2.aid FROM m2s_Staff s2 LEFT OUTER JOIN m2s_oversees o2 ON s2.SID = o2.staffID JOIN m2s_SpeciesGroup sg2 ON o2.sGroupName = sg2.latinName JOIN m2s_Species s2 ON s2.speciesGroup = sg2.latinName JOIN m2s_Animal a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {staffMemberId}) AND f.dateTime = (SELECT MAX(dateTime) FROM m2s_feed f2 WHERE a.aid = f2.animalid) OR a.aid NOT IN (SELECT DISTINCT animalID FROM m2s_FEED) ORDER BY f.dateTime ASC NULLS FIRST FETCH FIRST 5 ROWS ONLY";

            String query = $"SELECT a.aid, a.name, s3.commonName, f.datetime, a.feedingInterval " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("FEED")} f ON a.aid = f.animalid " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("SPECIES")} s3 ON a.speciesName = s3.latinName " +
                $"WHERE a.aid IN " +
                $"(SELECT a2.aid FROM {DatabaseHelper.Table("STAFF")} s2 " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("OVERSEES")} o2 ON s2.SID = o2.staffID " +
                $"JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg2 ON o2.sGroupName = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("SPECIES")} s2 ON s2.speciesGroup = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("ANIMAL")} a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {staffID}) " +
                $"AND f.dateTime = (SELECT MAX(dateTime) FROM {DatabaseHelper.Table("FEED")} f2 WHERE a.aid = f2.animalid) " +
                $"ORDER BY f.dateTime ASC NULLS FIRST " +
                $"FETCH FIRST {rows} ROWS ONLY";

            DataTable animals = DatabaseHelper.ExecuteQuery(query);
            return animals;
        }

        /**<summary>
         * Gets up to <param>rows</param> animals that this staff member is qualified to feed that have never been fed before.
         * This table may be empty if all animals have been fed at least once.
         * 
         * @Author Dolf ten Have
         * </summary>
         * <param name="rows">The maximum number of rows returned.</param>
         * <param name="staffID">The id of the staff member.</param>
         * <returns>A Datatable with up to <param>rows</param> animals that have never been fed before.</returns>
         */
        private DataTable getFeedingListForStaff_AnimalsNeverFed(int rows, int staffID)
        {
            String query = $"SELECT a.aid, a.name, s3.commonName, a.feedingInterval " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("SPECIES")} s3 ON a.speciesName = s3.latinName " +
                $"WHERE a.aid IN " +
                $"(SELECT a2.aid FROM {DatabaseHelper.Table("STAFF")} s2 " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("OVERSEES")} o2 ON s2.SID = o2.staffID " +
                $"JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg2 ON o2.sGroupName = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("SPECIES")} s2 ON s2.speciesGroup = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("ANIMAL")} a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {staffID}) " +
                // All the animals that are not in the feeding table
                $"AND a.aid NOT IN (SELECT DISTINCT animalID FROM {DatabaseHelper.Table("FEED")})" +
                $"FETCH FIRST {rows} ROWS ONLY";

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
            int remainingRows = 6;

            DataTable animals_notFed = getFeedingListForStaff_AnimalsNeverFed(remainingRows, staffMemberId);
            DataTable animals_fed = null;

            remainingRows -= animals_notFed.Rows.Count;
            groupBoxTODO.Text = "Feeding List:";
            
            if(remainingRows > 0) {
                animals_fed = getFeedingListForStaff(remainingRows, staffMemberId);
            }

            //If there are no animals that this person has/can feed then a message is displayed to the user.
            if(remainingRows < 1) { 
                Label lbl = new Label();
                lbl.Text = "There are no Animals that you need to feed.";
                lbl.AutoSize= true;
                lbl.Location = new System.Drawing.Point(groupBoxTODO.Location.X + 10, groupBoxTODO.Location.Y + 10 + lbl.Height);
                groupBoxTODO.Controls.Add(lbl);
                return;
            }

            DateTime currentTime = DateTime.Now;
            remainingRows = animals_notFed.Rows.Count;

            //Displays all the UI components
            for (int i = 0; i < animals_notFed.Rows.Count; i++)
            {
                makeTodoUiComponent_Feed(int.Parse(animals_fed.Rows[i][0].ToString()),animals_notFed.Rows[i][1].ToString(), animals_notFed.Rows[i][2].ToString(), -1, int.Parse(animals_notFed.Rows[i][3].ToString()), i);
            }

            if (animals_fed != null)
            {
                for (int i = 0; i < animals_fed.Rows.Count; i++)
                {
                    DateTime lastFed = (DateTime)animals_fed.Rows[i][3];
                    TimeSpan hours = currentTime - lastFed;

                    int totalTime = (int)hours.TotalHours;

                    makeTodoUiComponent_Feed(int.Parse(animals_fed.Rows[i][0].ToString()),animals_fed.Rows[i][1].ToString(), animals_fed.Rows[i][2].ToString(), totalTime, int.Parse(animals_fed.Rows[i][4].ToString()), remainingRows + i);
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
        private void makeTodoUiComponent_Feed(int aid, String name, String speciesName, int totalTime, int FeedingInterval, int n)
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

            //TODO implement calculateFeedTimeString
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
                    totalTime = (int)totalTime / 24;
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
            btnFeed.Tag = aid;
            btnFeed.Click += btnFeedClicked;
        }

        /**<summary>
         * An event handler that sends the user to the Enclosure tab.
         * It sets the current Enclosure to this tab and moved the user over to the enclosure tab
         * </summary>
         */
        private void btnFeedClicked(object sender, EventArgs e)
        {
            currentEnclosure = getAnimalEnclosure(int.Parse(((Button)sender).Tag.ToString()));
            tabControlMain.SelectTab(2);
        }

        /**<summary>Gets the enclosure id of an animal.</summary>
         *<returns>An integer with the id of the enclosure that the animal is in.</returns>
         */
        private int getAnimalEnclosure(int aid)
        {
            String query = $"SELECT enclosureid FROM {DatabaseHelper.Table("ANIMAL")} WHERE aid = {aid}";
            DataTable eid = DatabaseHelper.ExecuteQuery(query);
            return int.Parse(eid.Rows[0][0].ToString());
        }


        /**<summary>
         * Returns a string vaersion of how long ago the animal was last fed
         * </summary>
         */
        private String calculateLastFedTime(int lastFed)
        {
            String suffix = "h";

            if (lastFed == -1)
                return "Never!";

            if(lastFed > 24)
            { 
                lastFed = lastFed / 24;
                suffix = "d";
                if (lastFed > 365)
                {
                    lastFed = lastFed / 365;
                    suffix = "y";
                }
            }
            
            return lastFed.ToString()+suffix;
        }

        /**<summary>
         * Initialises the Enclosure page
         * </summary>
         */
        private void initialiseEnclosure()
        {
            vScrollBar_Enclosure.Value = panel_Enclosure_Animals.VerticalScroll.Value;
            vScrollBar_Enclosure.Minimum = panel_Enclosure_Animals.VerticalScroll.Minimum;
            vScrollBar_Enclosure.Minimum = panel_Enclosure_Animals.VerticalScroll.Minimum;
            vScrollBar_Enclosure.Scroll += vScrollBar_Enclosure_Scroll;
            vScrollBar_Enclosure.Enabled = false;

            loadEnclosureAnimals();

            vScrollBar_Enclosure.Enabled = true;
        }

        /**<summary>
         * Updates the the position of the panel to match the vertical scroll bar
         * </summary>
         */
        private void vScrollBar_Enclosure_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Enclosure_Animals.VerticalScroll.Value = vScrollBar_Enclosure.Value;
        }

        /**<summary>
         * Updated the maximum vertical scroll value when a control is added.
         * </summary>
         */
        private void panel_Enclosure_Animals_ControlAdded(object sender, ControlEventArgs e)
        {
            vScrollBar_Enclosure.Maximum = panel_Enclosure_Animals.VerticalScroll.Maximum;
        }

        /**<summary>
         * Updated the minimum scroll value when a control is removed
         * </summary>
         */
        private void panel_Enclosure_Animals_ControlRemoved(object sender, ControlEventArgs e)
        {
            vScrollBar_Enclosure.Minimum = panel_Enclosure_Animals.VerticalScroll.Minimum;
        }

        /**<summary>
         * Gets the enclosure name based on the ID of the enclosure.
         * If the search texbox is empty, then nothing is searched.
         * </summary>
         */
        private void button_Enclosure_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Enclosure_Search.Text))
            {
                MessageBox.Show("Please enter something into the search bar before searching.");
                return;
            }

            DataTable enclosureList = getEnclosuresByName(textBox_Enclosure_Search.Text);

            EnclosureIdList.Clear();
            comboBox_Enclosure_Search.Items.Clear();

            comboBox_Enclosure_Search.Items.Add(enclosureList.Rows.Count.ToString() + " Enclosures Found");
            //Adds a spoof id so that when a real enclosure is selected, it matches it list position
            EnclosureIdList.Add(-1);
            comboBox_Enclosure_Search.SelectedIndex = 0;

            for(int i = 0; i < enclosureList.Rows.Count; i++)
            {
                comboBox_Enclosure_Search.Items.Add(enclosureList.Rows[i][1].ToString() + " Enclosure");
                EnclosureIdList.Add(int.Parse(enclosureList.Rows[i][0].ToString()));
            }
        }

        /**<summary>
         * Searches for all enclosures who's name is a partial match for the current string in the search box
         * </summary>
         * <param name="name" type="String">The name of the enclosure.</param>
         * <returns>A DataTable with a list of all enclosure names that match the current search. May be empty.</returns>
         */
        private DataTable getEnclosuresByName(string name)
        {
            String query = $"SELECT eid, name FROM {DatabaseHelper.Table("ENCLOSURE")} WHERE name LIKE :search";
            List<Oracle.ManagedDataAccess.Client.OracleParameter> parameters = new List<Oracle.ManagedDataAccess.Client.OracleParameter>();
            parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("search", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2));
            parameters[0].Value = $"%{name}%";
            return DatabaseHelper.ExecuteQueryUsingParamList(query, parameters);
        }

        /**<summary>
         * Sets the current Enclosure to the enclosure that is selected from the list of enclosures.
         * Then calls loadEnclosureAnimals().
         * </summary>
         */
        private void comboBox_Enclosure_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the selected index is 0 then nothing new is loaded. This is the case if the header is selected or if there is already an enclosure loaded.
            if(comboBox_Enclosure_Search.SelectedIndex == 0)
            {
                return;
            }

            //If this is already the currentEnclosure, then the list is not reloaded
            if(comboBox_Enclosure_Search.SelectedIndex == currentEnclosure)
            {
                return;
            }
            
            currentEnclosure = EnclosureIdList[comboBox_Enclosure_Search.SelectedIndex];
            loadEnclosureAnimals();
        }

        /**<summary>
         * Gets the Name of an enclosure based on the id
         * </summary>
         * <param name="eid">The enclosure ID.</param>
         * <returns>
         * A DataTable containing the Name of the enclosure.
         * </returns>
         */
        private DataTable getEnclosureNameById(int eid)
        {
            String query = $"SELECT name FROM {DatabaseHelper.Table("ENCLOSURE")} WHERE eid = {eid}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /**<summary>
         * Return all the animals from a given enclosure that the given staff member is allowed to care for.
         * </summary>
         * <param name="sid">Staff ID</param>
         * <param name="eid">Enclosure ID</param>
         * <returns>A datatable with the animal id, name, species, last fed date and feeding interval for each animal.</returns>
         */
        private DataTable getEnclosureAnimals(int sid, int eid)
        {
            String query = $"SELECT a.aid, a.name, a.speciesName, f.datetime " +
                $"FROM {DatabaseHelper.Table("ANIMAL")} a " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("FEED")} f ON a.aid = f.animalid " +
                $"WHERE enclosureID = {eid} AND a.aid IN " +
                $"(SELECT a2.aid FROM {DatabaseHelper.Table("STAFF")} s2 " +
                $"LEFT OUTER JOIN {DatabaseHelper.Table("OVERSEES")} o2 ON s2.SID = o2.staffID " +
                $"JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg2 ON o2.sGroupName = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("SPECIES")} s2 ON s2.speciesGroup = sg2.latinName " +
                $"JOIN {DatabaseHelper.Table("ANIMAL")} a2 ON a2.speciesName = s2.latinName WHERE s2.sid = {sid}) " +
                $"AND f.dateTime = (SELECT MAX(dateTime) FROM {DatabaseHelper.Table("FEED")} f2 WHERE a.aid = f2.animalid) ";
            DataTable animals = DatabaseHelper.ExecuteQuery(query);
            return animals;
        }

        /**<summary>
         * This loads all the animals that the zookeper is allowed to care for for a given enclosure int o the enxlosure tab.
         * </summary>
         */
        private void loadEnclosureAnimals()
        {
            //Doesnt load any animal data if no enclosure is currently selected
            if(currentEnclosure == -1)
            {
                return;
            }

            DataTable animals = getEnclosureAnimals(staffMemberId, currentEnclosure);
            comboBox_Enclosure_Search.Items.Clear();
            comboBox_Enclosure_Search.Items.Add(getEnclosureNameById(currentEnclosure).Rows[0][0].ToString() + " Enclosure");
            comboBox_Enclosure_Search.SelectedIndex = 0;
            panel_Enclosure_Animals.Controls.Clear();
            selectedAnimalsCheckboxList.Clear();
            selectedAnimals.Clear();
            button_feedGroup.Enabled = false;
            textBox_Enclosure_Search.Text = string.Empty;

            DateTime currentTime = DateTime.Now;

            for (int i = 0; i < animals.Rows.Count; i++)
            {
                Panel p;
                if (animals.Rows[i][3] == null)
                {
                    p = makeFeedAnimalUiComponent_Enclosure(int.Parse(animals.Rows[i][0].ToString()), animals.Rows[i][1].ToString(), animals.Rows[i][2].ToString(), -1);
                }
                else
                {
                    DateTime lastFed = (DateTime)animals.Rows[i][3];
                    TimeSpan hours = currentTime - lastFed;

                    p = makeFeedAnimalUiComponent_Enclosure(int.Parse(animals.Rows[i][0].ToString()), animals.Rows[i][1].ToString(), animals.Rows[i][2].ToString(), (int)hours.TotalHours);
                }
                p.Location = new System.Drawing.Point(0, i * 25);
                panel_Enclosure_Animals.Controls.Add(p);
            }
        }

        /**<summary>
         * Creates a panel with information about an animal and a checkbox to select it
         * </summary>
         */
        private Panel makeFeedAnimalUiComponent_Enclosure(int aid, String name, String species,int lastFed)
        {
            Panel p = new Panel();
            Label animal = new Label();
            CheckBox selectAnimal = new CheckBox();

            // sets the panel size
            p.Width = panel_Enclosure_Animals.Width;
            p.Height = 24;

            animal.Text = $"{name}, {species}, {calculateLastFedTime(lastFed)}";
            animal.AutoSize = true;

            p.Controls.Add(animal);
            animal.Location = new System.Drawing.Point(0, 0);

            p.Controls.Add(selectAnimal);
            selectAnimal.Location = new System.Drawing.Point(p.Width - selectAnimal.Width - 5, 0);
            selectAnimal.Tag = aid;
            selectAnimal.CheckedChanged += SelectAnimal_CheckedChanged;
            selectedAnimalsCheckboxList.Add(selectAnimal);

            return p;
        }


        /**<summary>
         * Adds/removes the animal id to the list of the selected animals.
         * The id is taken from the tag of the sender.
         * </summary>
         */
        private void SelectAnimal_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                selectedAnimals.Add(int.Parse(((CheckBox)sender).Tag.ToString()));
            }
            else
            {
                selectedAnimals.Remove(int.Parse(((CheckBox)sender).Tag.ToString()));
            }

            //Dissables the button when it is clicked.
            if(selectedAnimals.Count == 0)
            {
                button_feedGroup.Enabled = false;
            }
            else
            {
                button_feedGroup.Enabled = true;
            }
        }

        /**<summary>
         * Deselects all the animals currently selected for feeding
         * </summary>
         */
        private void button_selectAllFeed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectedAnimalsCheckboxList.Count; i++)
            {
                selectedAnimalsCheckboxList[i].Checked = true;
            }
        }

        /**<summary>
         * Unselects all the animals in the list.
         * </summary>
         */
        private void button_selectNoneFeed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectedAnimalsCheckboxList.Count; i++)
            {
                selectedAnimalsCheckboxList[i].Checked = false;
            }
        }

        /**<summary>
         * Feeds all the animals that are currently selected
         * </summary>
         */
        private void button_feedGroup_Click(object sender, EventArgs e)
        {
            String animalList = "Feeding (aid): [";
            for(int i = 0; i < selectedAnimals.Count - 1; i++)
            {
                animalList += selectedAnimals[i].ToString();
                animalList += ",";
            }
            animalList += selectedAnimals[selectedAnimals.Count - 1].ToString() + "]";
            MessageBox.Show(animalList);
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
        /// Gets the current page from the NumericUpDown Control.
        /// </summary>
        private void populateZoneUIElements()
        {
            // Get page info
            NumericUpDown nud = this.numericUpDownZonePage;
            int currentPage = (int)nud.Value;

            // Query to get basic info on each Zone to populate the UI elements
            // Change this to be on rowname too?
            String initZoneDataQuery = $"SELECT name, colour, hexcode, rownum" +
                $"FROM " + 
                    $"(SELECT distinct z.name, z.colour, z.hexcode" +
                    $"FROM {DatabaseHelper.Table("ZONE")} z, {DatabaseHelper.Table("ENCLOSURE")} e, " +
                    $"{DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("SPECIES")} sp, " +
                    $"{DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("OVERSEES")} o " +
                    $"WHERE o.staffid = {staffMemberId} " +
                    $"AND o.sgroupname = sg.latinname " +
                    $"AND sg.latinname = sp.speciesgroup " +
                    $"AND sp.latinname = a.speciesname " +
                    $"AND a.enclosureID = e.eid " +
                    $"AND e.zonename = z.name" +
                    $"ORDER BY z.name) " +
                    $"";
            if (textBoxZoneSearch.Text != "")
            {
                initZoneDataQuery +=
                    $"AND z.name LIKE '%{textBoxZoneSearch.Text}%'";
            }

            DataTable basicZoneInfo = DatabaseHelper.ExecuteQuery(initZoneDataQuery);
            // WRITE SOMETHING FOR IF NO ZONE IS FOUND

            // Populate UI elements!
            for (int i = 1; i < basicZoneInfo.Rows.Count + 1; i++)
            {
                // First get the list of animals in that enclosure that are relevant...
                String animalsNeedingQuery = $"";

                DataTable animalCount = DatabaseHelper.ExecuteQuery(animalsNeedingQuery);
                   

            }
        }

        private void resetZonePaging()
        {
            // If search box contains nothing, then search all.
            String countQuery;
            if (textBoxZoneSearch.Text != "")
            {
                countQuery = $"SELECT COUNT(distinct name) " +
                $"FROM {DatabaseHelper.Table("ZONE")} " +
                $"WHERE name LIKE '%{textBoxZoneSearch.Text}%' " +
                $"AND name IN (" +
                    $"SELECT z.name " +
                    $"FROM {DatabaseHelper.Table("ZONE")} z, {DatabaseHelper.Table("ENCLOSURE")} e, " +
                    $"{DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("SPECIES")} sp, " +
                    $"{DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("OVERSEES")} o " +
                    $"WHERE o.staffid = '{staffMemberId}' " +
                    $"AND o.sgroupname = sg.latinname " +
                    $"AND sg.latinname = sp.speciesgroup " +
                    $"AND sp.latinname = a.speciesname " +
                    $"AND a.enclosureID = e.eid " +
                    $"AND e.zonename = z.name)";
            }
            else
            {
                countQuery = $"SELECT COUNT(distinct name) AS \"count\" " +
                $"FROM {DatabaseHelper.Table("ZONE")} " +
                $"WHERE name IN (" +
                    $"SELECT z.name " +
                    $"FROM {DatabaseHelper.Table("ZONE")} z, {DatabaseHelper.Table("ENCLOSURE")} e, " +
                    $"{DatabaseHelper.Table("ANIMAL")} a, {DatabaseHelper.Table("SPECIES")} sp, " +
                    $"{DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("OVERSEES")} o " +
                    $"WHERE o.staffid = '{staffMemberId}' " +
                    $"AND o.sgroupname = sg.latinname " +
                    $"AND sg.latinname = sp.speciesgroup " +
                    $"AND sp.latinname = a.speciesname " +
                    $"AND a.enclosureID = e.eid " +
                    $"AND e.zonename = z.name)";
            }

            DataTable countDt = DatabaseHelper.ExecuteQuery(countQuery);
            int totalCount = int.Parse(countDt.Rows[0]["count"].ToString());
            //int numPages = ((totalCount - 1 )/ NUM_ZONE_PAGE_ELEMENTS) + 1;
         
            NumericUpDown nud = this.numericUpDownZonePage;
            nud.Value = 1;
            nud.Minimum = 1;
            //nud.Maximum = numPages;
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

            //return;
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
                    initialiseEnclosure();
                    return;
                case 3:
                    // Zone Tab Logic
                    resetZonePaging();
                    populateZoneUIElements();
                    return;
                default:
                    return;

            }
        }


    }
}
