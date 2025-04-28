using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public static class DatabaseHelper
    {
        public static OracleConnection CurrentConnection { get; private set; }

        private static string connectionString = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=mh1155;Password=VwDzrCNPjV;";

        public static bool ConnectToDatabase()
        {
            try
            {
                CurrentConnection = new OracleConnection(connectionString);
                CurrentConnection.Open();
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Failed.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckSmallDataExists()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM animal_small", CurrentConnection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Small Dataset Found and Connected!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Small Dataset NOT Found!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking small dataset.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckBigDataExists()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM animal_big", CurrentConnection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Big Dataset Found and Connected!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Big Dataset NOT Found!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking big dataset.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void CloseConnection()
        {
            if (CurrentConnection != null && CurrentConnection.State == ConnectionState.Open)
            {
                CurrentConnection.Close();
            }
        }
    }
}
