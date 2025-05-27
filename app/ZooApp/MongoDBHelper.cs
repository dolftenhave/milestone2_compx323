using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;
using System.Data;

namespace ZooApp
{
    public static class MongoDBHelper
    {
        private static IMongoDatabase database;

        public enum DBCollection
        {
            Care = 0,
            Feed = 1,
            Staff = 2,
            Zone = 3,
            SpeciesGroup = 4
        }

        private static readonly string[] DBCollections = new string[5]{
            "Care",
            "Feed",
            "Staff",
            "Zone",
            "SpeciesGroup"
        };

        private static string getCollectionName(DBCollection collectionName)
        {
            return DBCollections[(int)collectionName];
        }

        // Replace this with your actual connection string from Compass
        private static string connectionString = "mongodb+srv://minsoehtut306:Minmin306htut1@cluster0.d7amife.mongodb.net/";

        public static void Initialize(string dbName = "Zoo")
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(dbName);
        }

        public static IMongoCollection<BsonDocument> GetCollection(DBCollection collectionName)
        {
            return database.GetCollection<BsonDocument>(getCollectionName(collectionName));
        }

        public static List<BsonDocument> FindAll(DBCollection collectionName)
        {
            return GetCollection(collectionName).Find(new BsonDocument()).ToList();
        }

        /**<summary>
         * Makes a query based on an aggrigation pipeline.
         * </summary>
         * <param name="collecionName">The name of the collection that contains the document.</param>
         * <param name="pipeline">An array of BsonDocuments that make up the aggrication pipeline.</param>
         * <returns>A List of BsonDocuments.</returns>
         */
        public static List<BsonDocument> AggrigateFind(DBCollection collectionName, BsonDocument[] pipeline)
        {
            return GetCollection(collectionName).Aggregate<BsonDocument>(pipeline).ToList();
        }

        public static void InsertDocument(DBCollection collectionName, BsonDocument document)
        {
            GetCollection(collectionName).InsertOne(document);
        }
    }
}

