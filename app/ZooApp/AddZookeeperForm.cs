/**
 * AddZookeeperForm.cs
 * 
 * Manages the species groups assigned to a Zookeeper.
 * Allows assigning, removing, and viewing qualifications.
 * 
 * @author Min Soe Htut
 */

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddZookeeperForm : Form
    {
        private int? currentSid;

        public AddZookeeperForm()
        {
            InitializeComponent();
        }

        public AddZookeeperForm(int sid) : this()
        {
            currentSid = sid;
        }

        private void AddZookeeperForm_Load(object sender, EventArgs e)
        {
            LoadZookeeperList();
            LoadSpeciesGroups();

            if (currentSid.HasValue)
            {
                foreach (ComboBoxItem item in cbSelectZookeeper.Items)
                {
                    if (item.Value == currentSid.Value.ToString())
                    {
                        cbSelectZookeeper.SelectedItem = item;
                        cbSelectZookeeper.Enabled = false;
                        break;
                    }
                }

                LoadAssignedGroups(currentSid.Value);
            }
        }

        private void LoadZookeeperList()
        {
            string query = @"
                SELECT DISTINCT s.sid, s.fName || ' ' || s.lName AS fullName
                FROM m2s_Staff s
                JOIN m2s_Oversees o ON s.sid = o.staffID";

            DataTable keepers = DatabaseHelper.ExecuteQuery(query);
            cbSelectZookeeper.Items.Clear();

            foreach (DataRow row in keepers.Rows)
            {
                cbSelectZookeeper.Items.Add(new ComboBoxItem(row["fullName"].ToString(), row["sid"].ToString()));
            }

            cbSelectZookeeper.SelectedIndex = keepers.Rows.Count > 0 ? 0 : -1;
        }

        private void LoadSpeciesGroups()
        {
            string query = "SELECT latinName, commonName FROM m2s_SpeciesGroup ORDER BY commonName";
            DataTable groups = DatabaseHelper.ExecuteQuery(query);

            lbAssignedGroups.Items.Clear();
            foreach (DataRow row in groups.Rows)
            {
                lbAssignedGroups.Items.Add(new ComboBoxItem(row["commonName"].ToString(), row["latinName"].ToString()));
            }
        }

        private void LoadAssignedGroups(int sid)
        {
            string query = "SELECT sGroupName FROM m2s_Oversees WHERE staffID = :sid";
            OracleParameter[] param = { new OracleParameter("sid", sid) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, param);

            lbAssignedGroups.ClearSelected(); // Deselect all first

            for (int i = 0; i < lbAssignedGroups.Items.Count; i++)
            {
                var item = (ComboBoxItem)lbAssignedGroups.Items[i];
                if (result.AsEnumerable().Any(r => r["sGroupName"].ToString() == item.Value))
                {
                    lbAssignedGroups.SetSelected(i, true); 
                }
            }
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (!(cbSelectZookeeper.SelectedItem is ComboBoxItem selectedKeeper))
            {
                MessageBox.Show("Please select a zookeeper.");
                return;
            }

            int sid = int.Parse(selectedKeeper.Value);

            // Remove all current groups first (safe reset)
            string deleteQuery = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
            DatabaseHelper.ExecuteNonQuery(deleteQuery, new OracleParameter[] {
                new OracleParameter("sid", sid)
            });

            foreach (ComboBoxItem group in lbAssignedGroups.SelectedItems)
            {
                string insertQuery = "INSERT INTO m2s_Oversees (sGroupName, staffID) VALUES (:group, :sid)";
                OracleParameter[] insertParams = {
                    new OracleParameter("group", group.Value),
                    new OracleParameter("sid", sid)
                };
                DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
            }

            MessageBox.Show("Zookeeper assignments updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(cbSelectZookeeper.SelectedItem is ComboBoxItem selectedKeeper))
            {
                MessageBox.Show("Please select a zookeeper.");
                return;
            }

            var confirm = MessageBox.Show("Remove all qualifications for this zookeeper?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string delete = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
            OracleParameter[] param = { new OracleParameter("sid", int.Parse(selectedKeeper.Value)) };
            DatabaseHelper.ExecuteNonQuery(delete, param);

            MessageBox.Show("Qualifications removed.");
            LoadAssignedGroups(int.Parse(selectedKeeper.Value));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
