using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbSharp.Model
{
    [BsonIgnoreExtraElements]
    public class ExprienceCardViewData
    {
        public int P_ID { get; set; }
        public int EX_ID { get; set; }
        public string COMPANY { get; set; }
        public string EPOSITION { get; set; }
        public DateTime? EFROM { get; set; }
        public DateTime? ETO { get; set; }
        public bool SERVE_TILL { get; set; }
        public int TExp { get; set; }
    }
}
