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
                    if (item.Value == currentSid.ToString())
                    {
                        cbSelectZookeeper.SelectedItem = item;
                        break;
                    }
                }

                cbSelectZookeeper.Enabled = false;
                LoadAssignedGroups(currentSid.Value);
            }
        }

        private void LoadZookeeperList()
        {
            string query = @"
                SELECT DISTINCT s.sid, s.fName || ' ' || s.lName AS fullName
                FROM m2s_Staff s
                JOIN m2s_Oversees o ON s.sid = o.staffID";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cbSelectZookeeper.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cbSelectZookeeper.Items.Add(new ComboBoxItem(row["fullName"].ToString(), row["sid"].ToString()));
            }

            if (!currentSid.HasValue && cbSelectZookeeper.Items.Count > 0)
                cbSelectZookeeper.SelectedIndex = 0;
        }

        private void LoadGroupList()
        {
            string query = "SELECT DISTINCT sGroupName FROM m2s_SpeciesGroup ORDER BY sGroupName";
            DataTable groups = DatabaseHelper.ExecuteQuery(query);

            lbAssignedGroups.Items.Clear();
            foreach (DataRow row in groups.Rows)
            {
                lbAssignedGroups.Items.Add(row["sGroupName"].ToString());
            }
        }

        private void LoadAssignedGroups(int sid)
        {
            string query = "SELECT sGroupName FROM m2s_Oversees WHERE staffID = :sid";
            OracleParameter[] param = { new OracleParameter("sid", sid) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, param);

            lbAssignedGroups.ClearSelected();
            foreach (string assignedGroup in result.AsEnumerable().Select(r => r["sGroupName"].ToString()))
            {
                int index = lbAssignedGroups.Items.IndexOf(assignedGroup);
                if (index >= 0)
                    lbAssignedGroups.SetSelected(index, true);
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

            string deleteQuery = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
            DatabaseHelper.ExecuteNonQuery(deleteQuery, new[] { new OracleParameter("sid", sid) });

            foreach (var selectedGroup in lbAssignedGroups.SelectedItems)
            {
                string insert = "INSERT INTO m2s_Oversees (staffID, sGroupName) VALUES (:sid, :group)";
                OracleParameter[] insertParams = {
                    new OracleParameter("sid", sid),
                    new OracleParameter("group", selectedGroup.ToString())
                };
                DatabaseHelper.ExecuteNonQuery(insert, insertParams);
            }

            MessageBox.Show("Species group(s) assigned to zookeeper.");
            this.Close();
            new SelectStaffForm().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(cbSelectZookeeper.SelectedItem is ComboBoxItem selectedKeeper))
            {
                MessageBox.Show("Select a zookeeper to delete assignments.");
                return;
            }

            int sid = int.Parse(selectedKeeper.Value);

            var confirm = MessageBox.Show("Are you sure you want to remove all group assignments?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string deleteQuery = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
            OracleParameter[] parameters = { new OracleParameter("sid", sid) };
            DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);

            MessageBox.Show("All group assignments deleted.");
            this.Close();
            new SelectStaffForm().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new SelectStaffForm().ShowDialog();
        }

        private void cbSelectZookeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectZookeeper.SelectedItem is ComboBoxItem selected)
            {
                LoadAssignedGroups(int.Parse(selected.Value));
            }
        }
    }
}
