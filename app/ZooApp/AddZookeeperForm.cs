using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class AddZookeeperForm : Form
    {
        private readonly StaffInfo staffInfo;
        private readonly bool isEditMode = false;
        private readonly int editingSid;

        // ----- Constructor for Add Mode -----
        public AddZookeeperForm(StaffInfo info)
        {
            InitializeComponent();
            staffInfo = info;
            isEditMode = false;
        }

        // ----- Constructor for Edit Mode -----
        public AddZookeeperForm(int existingStaffId)
        {
            InitializeComponent();
            editingSid = existingStaffId;
            isEditMode = true;
        }

        private void AddZookeeperForm_Load(object sender, EventArgs e)
        {
            LoadSpeciesGroups();

            if (isEditMode)
                LoadSelectedGroups();
        }

        private void LoadSpeciesGroups()
        {
            try
            {
                string query = "SELECT latinName FROM m2s_SpeciesGroup";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                clbSpeciesGroups.Items.Clear();
                foreach (DataRow row in dt.Rows)
                    clbSpeciesGroups.Items.Add(row["latinName"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load species groups: " + ex.Message);
                this.Close();
            }
        }

        private void LoadSelectedGroups()
        {
            try
            {
                string query = "SELECT sGroupName FROM m2s_Oversees WHERE staffID = :sid";
                OracleParameter[] p = { new OracleParameter("sid", editingSid) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

                foreach (DataRow row in dt.Rows)
                {
                    string groupName = row["sGroupName"].ToString();
                    int index = clbSpeciesGroups.Items.IndexOf(groupName);
                    if (index >= 0)
                        clbSpeciesGroups.SetItemChecked(index, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load assigned groups: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (clbSpeciesGroups.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one species group.");
                return;
            }

            try
            {
                int sid;

                if (isEditMode)
                {
                    sid = editingSid;

                    // Delete old records
                    string deleteQuery = "DELETE FROM m2s_Oversees WHERE staffID = :sid";
                    OracleParameter[] p = { new OracleParameter("sid", sid) };
                    DatabaseHelper.ExecuteNonQuery(deleteQuery, p);
                }
                else
                {
                    // Generate SID
                    string getSidQuery = "SELECT NVL(MAX(sid), 0) + 1 FROM m2s_Staff";
                    sid = Convert.ToInt32(DatabaseHelper.ExecuteQuery(getSidQuery).Rows[0][0]);

                    // Insert into Staff
                    string insertStaff = @"
                        INSERT INTO m2s_Staff 
                        (sid, fName, lName, dob, phNumber, email, streetNumber, streetName, suburb, city, postCode, clinic, sex)
                        VALUES 
                        (:sid, :fName, :lName, :dob, :phNumber, :email, :streetNumber, :streetName, :suburb, :city, :postCode, NULL, :sex)";

                    OracleParameter[] staffParams = new OracleParameter[]
                    {
                        new OracleParameter("sid", sid),
                        new OracleParameter("fName", staffInfo.FirstName),
                        new OracleParameter("lName", staffInfo.LastName),
                        new OracleParameter("dob", staffInfo.DOB),
                        new OracleParameter("phNumber", staffInfo.Phone),
                        new OracleParameter("email", staffInfo.Email),
                        new OracleParameter("streetNumber", staffInfo.StreetNumber),
                        new OracleParameter("streetName", staffInfo.StreetName),
                        new OracleParameter("suburb", staffInfo.Suburb),
                        new OracleParameter("city", staffInfo.City),
                        new OracleParameter("postCode", staffInfo.PostCode),
                        new OracleParameter("sex", staffInfo.Sex)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertStaff, staffParams);
                }

                // Insert selected groups
                foreach (var item in clbSpeciesGroups.CheckedItems)
                {
                    string insertOversees = @"
                        INSERT INTO m2s_Oversees (sGroupName, staffID)
                        VALUES (:groupName, :sid)";

                    OracleParameter[] overseesParams = new OracleParameter[]
                    {
                        new OracleParameter("groupName", item.ToString()),
                        new OracleParameter("sid", sid)
                    };

                    DatabaseHelper.ExecuteNonQuery(insertOversees, overseesParams);
                }

                MessageBox.Show("Zookeeper info saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save zookeeper info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
