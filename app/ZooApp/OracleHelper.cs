using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ZooApp
{
    public static class OracleHelper
    {
        private static OracleConnection conn = null;
        public static string ConnectionString { get; set; }

        public static void Connect()
        {
            if (conn == null)
            {
                conn = new OracleConnection(ConnectionString);
                conn.Open();
            }
        }

        public static void Disconnect()
        {
            if (conn != null)
            {
                conn.Dispose();
                conn = null;
            }
        }

        public static OracleDataReader ExecuteReader(string query)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            return cmd.ExecuteReader();
        }

        public static int ExecuteNonQuery(string query)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            return cmd.ExecuteNonQuery();
        }

        public static object ExecuteScalar(string query)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            return cmd.ExecuteScalar();
        }
    }
}
