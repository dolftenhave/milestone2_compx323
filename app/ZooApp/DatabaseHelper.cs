using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ZooApp
{
    public static class DatabaseHelper
    {
        // Default prefix for M2S_ tables; can be updated at login
        private static string currentTablePrefix = "M2S";

        // Change this to your actual connection string
        public static string connectionString = "User Id=mh1155;Password=VwDzrCNPjV;Data Source=oracle.cms.waikato.ac.nz:1521/teaching;";

        // Used to switch between datasets (M2S, M21, etc.)
        public static void SetTablePrefix(string prefix)
        {
            currentTablePrefix = prefix;
        }

        // Returns a table name like "M2S_ANIMAL"
        public static string Table(string baseName)
        {
            return $"{currentTablePrefix}_{baseName}";
        }

        // Executes a SELECT and returns a filled DataTable
        public static DataTable ExecuteQuery(string query, OracleParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Executes INSERT, UPDATE, or DELETE with parameters
        public static void ExecuteNonQuery(string query, OracleParameter[] parameters)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Tests if database connection is valid
        public static bool TestConnection()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
