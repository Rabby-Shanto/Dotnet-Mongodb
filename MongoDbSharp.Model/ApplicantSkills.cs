
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbSharp.Model
{
    public class ApplicantSkills
    {
        public int P_ID {  get; set; }
        [BsonElement("SkillId")]
        public string SkillID { get; set;}
    }
}
