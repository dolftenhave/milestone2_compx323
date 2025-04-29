using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

public static class DatabaseHelper
{
    private static string connectionString =
        "User Id=mh1155;Password=VwDzrCNPjV;Data Source=oracle.cms.waikato.ac.nz:1521/teaching;";

    private static string datasetPrefix = "M2S"; // default to small

    public static void SetDatasetMode(string prefix)
    {
        datasetPrefix = prefix;
    }

    public static string Table(string baseName)
    {
        return $"{datasetPrefix}_{baseName}";
    }

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
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return dataTable;
    }
    public static void ExecuteNonQuery(string query, OracleParameter[] parameters)
    {
        using (OracleConnection conn = new OracleConnection(connectionString))
        {
            conn.Open();
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }
    }
    public static DataTable ExecuteQuery(string query, OracleParameter[] parameters)
    {
        DataTable dataTable = new DataTable();

        try
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return dataTable;
    }


}
