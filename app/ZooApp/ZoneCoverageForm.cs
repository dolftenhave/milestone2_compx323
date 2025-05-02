using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ZooApp
{
    public partial class ZoneCoverageForm : Form
    {
        private int staffId;

        public ZoneCoverageForm(int sid)
        {
            InitializeComponent();
            staffId = sid;
        }

        private void ZoneCoverageForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                SELECT 
                    z.name AS zoneName,
                    COUNT(DISTINCT e.eid) AS totalEnclosures,
                    COUNT(DISTINCT CASE 
                        WHEN EXISTS (
                            SELECT 1 
                            FROM {DatabaseHelper.Table("Animal")} a 
                            JOIN {DatabaseHelper.Table("Species")} s ON a.speciesName = s.latinName 
                            JOIN {DatabaseHelper.Table("SpeciesGroup")} sg ON s.speciesGroup = sg.latinName 
                            JOIN {DatabaseHelper.Table("Oversees")} o ON sg.latinName = o.speciesGroup 
                            WHERE o.sid = :sid AND a.enclosureID = e.eid
                        ) THEN e.eid 
                        ELSE NULL 
                    END) AS coveredEnclosures
                FROM {DatabaseHelper.Table("Zone")} z
                LEFT JOIN {DatabaseHelper.Table("Enclosure")} e ON z.name = e.zoneName
                GROUP BY z.name
                ";


                OracleParameter[] p = { new OracleParameter("sid", staffId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendLine($"{row["zoneName"]}: {row["coverage_percent"]}%");
                }

                txtCoverage.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating coverage: {ex.Message}");
            }
        }
    }
}
