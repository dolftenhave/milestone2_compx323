/**
 * AddZookeeperForm.cs
 * 
 * Allows assigning species groups to zookeepers.
 * Uses CheckedListBox for multiple group selection.
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

        public AddZookeeperForm(int sid)
        {
            InitializeComponent();
            currentSid = sid;
        }

        private void AddZookeeperForm_Load(object sender, EventArgs e)
        {
            LoadZookeeperList();
            LoadGroupList();

            if (currentSid.HasValue)
            {
                foreach (ComboBoxItem item in cbSelectZookeeper.Items)
                {
                    if (item.Value == currentSid.Value.ToString())
                    {
                        cbSelectZookeeper.SelectedItem = item;
                        cbSelectZookeeper.Enabled = false;
                        cbSelectZookeeper_SelectedIndexChanged(null, null);
                        break;
                    }
                }
            }
        }


        private void LoadZookeeperList()
        {
            string query = $@"
        SELECT s.sid, s.fName || ' ' || s.lName AS fullName
        FROM {DatabaseHelper.Table("Staff")} s
        WHERE s.sid IN (
            SELECT DISTINCT staffID FROM {DatabaseHelper.Table("Oversees")}
        )";

            DataTable keepers = DatabaseHelper.ExecuteQuery(query);

            cbSelectZookeeper.Items.Clear();
            foreach (DataRow row in keepers.Rows)
            {
                cbSelectZookeeper.Items.Add(new ComboBoxItem(
                    row["fullName"].ToString(),
                    row["sid"].ToString()
                ));
            }

            cbSelectZookeeper.SelectedIndex = -1;

        }

        private void LoadGroupList()
        {
            string query = $@"
        SELECT commonName 
        FROM {DatabaseHelper.Table("SpeciesGroup")}
        ORDER BY commonName";

            DataTable groups = DatabaseHelper.ExecuteQuery(query);

            clbGroups.Items.Clear();
            foreach (DataRow row in groups.Rows)
            {
                clbGroups.Items.Add(row["commonName"].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(cbSelectZookeeper.SelectedItem is ComboBoxItem selectedKeeper))
            {
                MessageBox.Show("Please select a zookeeper.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sid = int.Parse(selectedKeeper.Value);

            // Step 1: Delete current group assignments
            string deleteQuery = $"DELETE FROM {DatabaseHelper.Table("Oversees")} WHERE staffID = :sid";
            OracleParameter[] deleteParam = { new OracleParameter("sid", sid) };
            DatabaseHelper.ExecuteNonQuery(deleteQuery, deleteParam);

            // Step 2: Re-insert the checked groups
            foreach (var item in clbGroups.CheckedItems)
            {
                if (item is ComboBoxItem group)
                {
                    string insertQuery = $@"
                INSERT INTO {DatabaseHelper.Table("Oversees")}
                (sGroupName, staffID) VALUES (:grp, :sid)";

                    OracleParameter[] insertParams = {
                new OracleParameter("grp", group.Value),
                new OracleParameter("sid", sid)
            };

                    DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                }
            }

            MessageBox.Show("Zookeeper assignments updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString() => Text;
        }

        private void cbSelectZookeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbSelectZookeeper.SelectedItem is ComboBoxItem selectedKeeper))
                return;

            int sid = int.Parse(selectedKeeper.Value);

            // Reload all groups first
            clbGroups.Items.Clear();
            string allGroupsQuery = $@"SELECT commonName, latinName FROM {DatabaseHelper.Table("SpeciesGroup")} ORDER BY commonName";
            DataTable allGroups = DatabaseHelper.ExecuteQuery(allGroupsQuery);

            foreach (DataRow row in allGroups.Rows)
            {
                clbGroups.Items.Add(new ComboBoxItem(row["commonName"].ToString(), row["latinName"].ToString()), false);
            }

            // Load assigned species groups for this keeper
            string assignedQuery = $@"SELECT sGroupName FROM {DatabaseHelper.Table("Oversees")} WHERE staffID = :sid";
            OracleParameter[] param = { new OracleParameter("sid", sid) };
            DataTable assignedGroups = DatabaseHelper.ExecuteQuery(assignedQuery, param);

            // Tick the assigned groups
            for (int i = 0; i < clbGroups.Items.Count; i++)
            {
                if (clbGroups.Items[i] is ComboBoxItem item)
                {
                    bool isAssigned = assignedGroups.AsEnumerable()
                        .Any(r => r["sGroupName"].ToString() == item.Value);
                    clbGroups.SetItemChecked(i, isAssigned);
                }
            }
        }

    }
}
