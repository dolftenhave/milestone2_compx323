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
        public SelectStaffForm()
        {
            InitializeComponent();
        }

        private void SelectStaffForm_Load(object sender, EventArgs e)
        {

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

    }
}
