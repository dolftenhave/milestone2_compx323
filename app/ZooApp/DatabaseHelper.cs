using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace ZooApp
{
    public static class DatabaseHelper
    {
        private static OracleConnection connection;

        private static string connectionString = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=mh1155;Password=VwDzrCNPjV;";

        public static bool ConnectToDatabase()
        {
            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
                return false;
            }
        }

        public static OracleConnection GetConnection()
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                ConnectToDatabase();
            }
            return connection;
        }

        public static void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        // OPTIONAL helper for SELECT queries
        public static DataTable ExecuteQuery(string sql)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(sql, GetConnection());
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query failed: " + ex.Message);
                return null;
            }
        }

        // OPTIONAL helper for INSERT/UPDATE/DELETE
        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(sql, GetConnection());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NonQuery failed: " + ex.Message);
                return -1;
            }
        }
        // Dummy methods for now
        public static void CheckSmallDataExists()
        {
            MessageBox.Show("Small dataset selected and ready to use!");
        }

        public static void CheckBigDataExists()
        {
            MessageBox.Show("Big dataset selected and ready to use!");
        }
    }
}
