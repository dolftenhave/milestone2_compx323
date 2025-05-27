using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

/**
 * <author>Dolf ten Have</author>
 * A set of POCO classes for the mongoDB application.
 */
namespace ZooApp.POCO
{
    /**<summary>The Zone field</summary>
     */
    public class Zone
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("colour")]
        public string colour { get; set; }
        [BsonElement("hexcode")]
        public string hexcode { get; set; }
        [BsonElement("enclosures")]
        public List<Enclosure> enclosures { get; set; }

    }

    public class Enclosure
    {
        [BsonElement("eid")]
        public int eid { get; set; }
        [BsonElement("name")]
        public string name { set; get; }
        [BsonElement("biome")]
        public string biome { set; get; }
        [BsonElement("eSize")]
        public int eSize { set; get; }
        [BsonElement("animal")]
        public List<Animal> animals { get; set; }
    }

    public class Animal
    {
        [BsonElement("aid")]
        public int aid { set; get; }
    }
}
