using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    /// <summary>
    /// Class to store query strings in one place
    /// </summary>
    internal static class Queries
    {
        // Make sure to add the animal ID on to the end of this
        public static String ZookeepersQualifiedForAnimal =
            $"SELECT s.sid, s.lname, s.fname " +
            $"FROM {DatabaseHelper.Table("STAFF")} s, " +
            $"{DatabaseHelper.Table("SPECIESGROUP")} sg, " +
            $"{DatabaseHelper.Table("SPECIES")} sp, " +
            $"{DatabaseHelper.Table("ANIMAL")} a, " +
            $"{DatabaseHelper.Table("OVERSEES")} o " +
            $"WHERE s.sid = o.staffID " +
            $"AND o.sGroupName = sg.latinName " +
            $"AND sp.speciesGroup = sg.latinName " +
            $"AND a.speciesName = sp.latinName";
    }
}
