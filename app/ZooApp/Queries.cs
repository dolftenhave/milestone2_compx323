using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        // Query to load the Animals table
        public static String LoadAnimalsQuery = $@"
                    SELECT 
                        a.aid,
                        a.name,
                        a.sex,
                        a.dob,
                        a.weight,
                        a.feedingInterval,
                        a.originCountry,
                        a.enclosureID,
                        e.biome,
                        e.zoneName,
                        a.speciesName,
                        sg.commonName AS speciesGroup
                    FROM {DatabaseHelper.Table("ANIMAL")} a
                    LEFT JOIN {DatabaseHelper.Table("ENCLOSURE")} e ON a.enclosureID = e.eid
                    LEFT JOIN {DatabaseHelper.Table("SPECIES")} s ON a.speciesName = s.latinName
                    LEFT JOIN {DatabaseHelper.Table("SPECIESGROUP")} sg ON s.speciesGroup = sg.latinName
                    WHERE 1=1";

        // Query to load the Enclosures table
        public static String LoadEnclosuresQuery =
            $"SELECT e.eid, e.biome, e.esize, z.name AS zoneName " +
            $"FROM {DatabaseHelper.Table("ENCLOSURE")} e " +
            $"JOIN {DatabaseHelper.Table("ZONE")} z ON e.zoneName = z.name";

        // Query to load the Staff table
        public static String LoadStaffQuery = $@"
            SELECT
                s.sid,
                s.fName || ' ' || s.lName AS fullName,
                s.dob,
                s.sex,
                s.phNumber,
                s.email,
                s.streetNumber || ' ' || s.streetName || ', ' || s.suburb || ', ' || s.city || ' ' || s.postCode AS address,
                s.clinic,
                CASE
                    WHEN EXISTS (SELECT 1 FROM {DatabaseHelper.Table("FEED")} f WHERE f.staffID = s.sid) THEN 'Zookeeper'
                    WHEN EXISTS (SELECT 1 FROM {DatabaseHelper.Table("CARE")} c WHERE c.staffID = s.sid) THEN 'Vet'
                    ELSE 'Unknown'
                END AS role
            FROM {DatabaseHelper.Table("STAFF")} s
            WHERE 1=1
            ";

        // Query to load the Feeding and Care tables (same time)
        public static String LoadFeedingAndCareQuery = $@"
        SELECT 
            F.staffID,
            S.fName || ' ' || S.lName AS StaffName,
            F.animalID,
            A.name AS AnimalName,
            F.dateTime,
            'Feeding' AS Type,
            F.foodType AS FoodType,
            TO_CHAR(F.amount) AS FoodAmount,
            NULL AS CareType,
            NULL AS VetNotes
        FROM {DatabaseHelper.Table("FEED")} F
        JOIN {DatabaseHelper.Table("STAFF")} S ON F.staffID = S.sid
        JOIN {DatabaseHelper.Table("ANIMAL")} A ON F.animalID = A.aid

        UNION ALL

        SELECT 
            C.staffID,
            S.fName || ' ' || S.lName AS StaffName,
            C.animalID,
            A.name AS AnimalName,
            C.dateTime,
            'Care' AS Type,
            NULL AS FoodType,
            NULL AS FoodAmount,
            C.care AS CareType,
            C.notes AS VetNotes
        FROM {DatabaseHelper.Table("CARE")} C
        JOIN {DatabaseHelper.Table("STAFF")} S ON C.staffID = S.sid
        JOIN {DatabaseHelper.Table("ANIMAL")} A ON C.animalID = A.aid

        ORDER BY dateTime DESC";

    }

    
}
