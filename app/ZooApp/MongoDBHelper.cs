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

        // Replace this with your actual connection string from Compass
        private static string connectionString = "mongodb+srv://minsoehtut306:Minmin306htut1@cluster0.d7amife.mongodb.net/";

        public static void Initialize(string dbName = "Zoo")
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(dbName);
        }

        public static IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public static List<BsonDocument> FindAll(string collectionName)
        {
            return GetCollection(collectionName).Find(new BsonDocument()).ToList();
        }

        /**<summary>
         * An internal method that converts the data returnd form the mongoDB collection to a DataTable.
         * </summary>
         * <param name="data">The IMongoDatabase results.</param>
         * <returns>A DataTable containing all MongoDatabase data</returns>
         */
        private static DataTable toDataTable(IMongoDatabase data)
        {
            DataTable dt = new DataTable();
            //TODO Dolf will implement.
            return dt;
        }

        public static void InsertDocument(string collectionName, BsonDocument document)
        {
            GetCollection(collectionName).InsertOne(document);
        }
    }
}

