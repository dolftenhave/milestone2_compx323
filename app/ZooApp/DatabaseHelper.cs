using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

public static class DatabaseHelper
{
    private static string connectionString = "User Id=mh1155;Password=VwDzrCNPjV;Data Source=oracle.cms.waikato.ac.nz:1521/teaching;";

    public static DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();

        try
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Database error: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        return dataTable;
    }

    public static int ExecuteNonQuery(string query)
    {
        int rowsAffected = 0;

        try
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Database error: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        return rowsAffected;
    }
    public static bool TestConnection()
    {
        try
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("✅ Connection to Oracle is successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"❌ Connection failed: {ex.Message}", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

}
