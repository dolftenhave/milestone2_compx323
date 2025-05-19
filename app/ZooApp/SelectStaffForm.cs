using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class SelectStaffForm : Form
    {
        private DataTable staffList;
        public SelectStaffForm()
        {
            InitializeComponent();
        }

        private void SelectStaffForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectStaff_LoadStaffList();
        }

        /**
         * <summary>
         * Loads a list of all staff members into the combobox items
         * @author Dolf ten Have
         * </summary>
         */
        private void comboBoxSelectStaff_LoadStaffList()
        {
            cbSelectStaff.Items.Clear();
            cbSelectStaff.Items.Add("Select Your Name");
            getStaff();
            for (int i = 0; i < staffList.Rows.Count; i++)
            {
                cbSelectStaff.Items.Add(staffList.Rows[i][1]);
            }

            cbSelectStaff.SelectedIndex = 0;
        }

        /** <summary>
        *  Gets the staff names for the dropdown names list.
        *  @author Dolf ten Have
        * </summary>
        */
        private void getStaff()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!
            //     THIS METHOD IS NOT FOR PUTTING DATA INTO THE COMBO BOX
            //!!!!!!!!!!!!!!!!!!!!!!!!!
            String query = $"SELECT sid, fname || ' ' || lname AS \"Fullname\" FROM {DatabaseHelper.Table("STAFF")}";
            staffList = DatabaseHelper.ExecuteQuery(query);


            // LOOK AT comboBoxSelectStaff_LoadStaffList IF YOU WANT TO LOAD DATA INTO THE COMBOBOX
            /**
                cbSelectStaff.Items.Clear();
                cbSelectStaff.Items.Add("Select Staff");

                foreach (DataRow row in staffList.Rows)
                {
                    string display = $"{row["Fullname"]}";
                    cbSelectStaff.Items.Add(new ComboBoxItem(display, row["sid"].ToString()));
                }

                cbSelectStaff.SelectedIndex = 0;
            */
        }

        /// <summary>
        /// Handle the Add New Staff button click event.
        /// Opens the AddStaffForm as a dialog.
        /// @author Min Soe Htut
        /// </summary>
        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            using (AddStaffForm form = new AddStaffForm())
            {
                form.ShowDialog();

                // Refresh the staff list after closing the form
                comboBoxSelectStaff_LoadStaffList();
            }
        }


        /// <summary>
        /// Handle the Quit button click event.
        /// Closes the application.
        /// @author Min Soe Htut
        /// </summary>
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * <summary>
         * Checks if a staff member has been selected by the user. Otherwise an alert message is shown to notify the user to select their name.
         * @author Dolf ten Have
         * </summary>
         */
        private void buttonLogin_Click(object sender, EventArgs e)
        {
           Label chooseNameAlert;

            //Issues a warning to the user to choose a name.
           if (cbSelectStaff.SelectedIndex < 1) {
                chooseNameAlert = new Label();
                chooseNameAlert.Text = "Please select your name to continue.";
                chooseNameAlert.AutoSize= true;
                chooseNameAlert.ForeColor = Color.Red;
                chooseNameAlert.Location = new Point(cbSelectStaff.Location.X, cbSelectStaff.Location.Y + cbSelectStaff.Height);
                this.Controls.Add(chooseNameAlert);
                return;
            }
            try
            {
                String staffId = staffList.Rows[cbSelectStaff.SelectedIndex][0].ToString();
                int staffIdInt = int.Parse(staffId);
                this.Hide();
                new MainForm(staffIdInt).ShowDialog();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            
            //Otherwise move to the next page
        }

        private void butUpdateVet_Click(object sender, EventArgs e)
        {
            new AddVetForm().ShowDialog();
        }
    }
}
