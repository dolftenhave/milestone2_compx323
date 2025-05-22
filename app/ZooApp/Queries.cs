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

        // Make sure to add the encloure ID at the end of this
        public static String ZookeepersQualifiedForEnclosure = $@"
            SELECT s.sid, s.lname, s.fname
            FROM {DatabaseHelper.Table("STAFF")} s, {DatabaseHelper.Table("OVERSEES")} o
            WHERE s.sid = o.staffid
            AND o.sgroupname = ALL(
            SELECT distinct sg.latinName
            FROM {DatabaseHelper.Table("SPECIESGROUP")} sg, {DatabaseHelper.Table("SPECIES")} sp, {DatabaseHelper.Table("ANIMAL")} a
            WHERE sp.latinName = a.speciesName
            AND sp.speciesgroup = sg.latinName";

        public static String AnimalsInEnclosure = $@"
            SELECT a.aid, a.name
            FROM {DatabaseHelper.Table("ENCLOSURE")} e
            JOIN {DatabaseHelper.Table("ANIMAL")} a on e.eid = a.enclosureid
        ";

        public static String PossibleEnclosuresForAnimal = $@"
            SELECT e.eid, e.zoneName
            FROM {DatabaseHelper.Table("ANIMAL")} a,
            {DatabaseHelper.Table("ENCLOSURE")} e,
            {DatabaseHelper.Table("SPECIES")} s
            WHERE a.speciesName = s.latinName
            AND s.requiredBiome = e.biome
        ";

        public static String ZookeeperQualifications = $@"
            SELECT sg.commonName
            FROM {DatabaseHelper.Table("OVERSEES")} o, 
            {DatabaseHelper.Table("SPECIESGROUP")} sg
            WHERE o.sGroupName = sg.latinName
        ";

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

        //Line is to make sure i can find my queries 
        //---------------------------------------------------------------------------//
        //Animal

        /// <summary>
        /// Loads all animals for selection (dropdown combo).
        /// </summary>
        public static string SelectAllAnimals = $@"
        SELECT aid, name 
        FROM {DatabaseHelper.Table("Animal")} 
        ORDER BY aid";

        /// <summary>
        /// Inserts a new animal with full details.
        /// </summary>
        public static string InsertAnimal = $@"
        INSERT INTO {DatabaseHelper.Table("Animal")} 
        (aid, name, dob, weight, originCountry, feedingInterval, sex, enclosureID, speciesName) 
        VALUES (:aid, :name, :dob, :weight, :origin, :feeding, :sex, :enclosure, :species)";

        /// <summary>
        /// Updates existing animal details by ID.
        /// </summary>
        public static string UpdateAnimal = $@"
        UPDATE {DatabaseHelper.Table("Animal")} 
        SET name = :name, dob = :dob, weight = :weight, originCountry = :origin, 
            feedingInterval = :feeding, sex = :sex, enclosureID = :enclosure, speciesName = :species 
        WHERE aid = :aid";

        /// <summary>
        /// Deletes an animal by ID.
        /// </summary>
        public static string DeleteAnimal = $@"
        DELETE FROM {DatabaseHelper.Table("Animal")} 
        WHERE aid = :aid";

        /// <summary>
        /// Gets full details for an animal by ID (including species and group join).
        /// </summary>
        public static string SelectAnimalById = $@"
        SELECT a.*, s.commonName AS speciesCommon, s.requiredBiome, s.speciesGroup,
               sg.commonName AS groupCommon
        FROM {DatabaseHelper.Table("Animal")} a
        JOIN {DatabaseHelper.Table("Species")} s ON a.speciesName = s.latinName
        LEFT JOIN {DatabaseHelper.Table("SpeciesGroup")} sg ON s.speciesGroup = sg.latinName
        WHERE a.aid = :aid";

        //----------------------------------------------
        //Species


        // Get all species latin names only
        public static string SelectAllSpecies = $@"
        SELECT latinName 
        FROM {DatabaseHelper.Table("Species")} 
        ORDER BY latinName";

        // Get full species details by latin name
        public static string SelectSpeciesByLatinName = $@"
        SELECT * 
        FROM {DatabaseHelper.Table("Species")} 
        WHERE latinName = :name";

        // Insert a new species record
        public static string InsertSpecies = $@"
        INSERT INTO {DatabaseHelper.Table("Species")} 
        (latinName, commonName, requiredBiome, speciesGroup) 
        VALUES (:latin, :common, :biome, :group)";

        // Update an existing species record by latin name
        public static string UpdateSpecies = $@"
        UPDATE {DatabaseHelper.Table("Species")} 
        SET commonName = :common, 
            requiredBiome = :biome, 
            speciesGroup = :group 
        WHERE latinName = :latin";

        // Delete a species record by latin name
        public static string DeleteSpecies = $@"
        DELETE FROM {DatabaseHelper.Table("Species")} 
        WHERE latinName = :latin";

        // Get all species group latin names
        public static string SelectAllSpeciesGroups = $@"
        SELECT latinName 
        FROM {DatabaseHelper.Table("SpeciesGroup")} 
        ORDER BY latinName";

        // Get full species group details by latin name
        public static string SelectSpeciesGroupByLatinName = $@"
        SELECT * 
        FROM {DatabaseHelper.Table("SpeciesGroup")} 
        WHERE latinName = :name";

        // Insert a new species group record
        public static string InsertSpeciesGroup = $@"
        INSERT INTO {DatabaseHelper.Table("SpeciesGroup")} 
        (latinName, commonName) 
        VALUES (:latin, :common)";

        // Update an existing species group record by latin name
        public static string UpdateSpeciesGroup = $@"
        UPDATE {DatabaseHelper.Table("SpeciesGroup")} 
        SET commonName = :common 
        WHERE latinName = :latin";

        // Delete a species group record by latin name
        public static string DeleteSpeciesGroup = $@"
        DELETE FROM {DatabaseHelper.Table("SpeciesGroup")} 
        WHERE latinName = :latin";






    }
}
