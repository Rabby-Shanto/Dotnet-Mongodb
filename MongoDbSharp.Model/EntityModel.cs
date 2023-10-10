using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbSharp.Model
{
    [BsonIgnoreExtraElements]
    public class EntityModel
    {     
        [BsonId,BsonElement("_id"),BsonRepresentation(BsonType.ObjectId)]
        public string P_Id { get; set; }
        public List<JobInformation> jobInformations { get; set; }
        [BsonElement("applyId")]
        public int ApplyID { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("mobile")]
        public string MOBILE { get; set; }
        [BsonElement("home_phone")]
        public string HOME_PHONE { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; }
        [BsonElement("birth")]
        public DateTime BIRTH { get; set; }
        [BsonElement("attachCv")]
        public bool AttachCV { get; set; }
        [BsonElement("videoCv")]
        public bool VDOCV { get; set; }
        [BsonElement("fileType")]
        public string FileType { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("currentSalary")]
        public int CurrentSalary { get; set; }
        [BsonElement("pref")]
        public string PREF { get; set; }
        [BsonElement("location")]
        public string UserLocation { get; set; }
        public string ParmanentAddress { get; set; }
        public bool PhotoUploaded { get; set; }
        public string PhotoName { get; set; }
        public string InstituteName { get; set; }
        public string DegreeName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public List<ApplicantSkills> Skills { get; set; }
        public ExprienceCardViewDataDTO Card1ExperienceData { get; set; }
        public ExprienceCardViewDataDTO Card2ExperienceData { get; set; }
        public List<EducationInfo> EducationList { get; set; }
        public string KeywordSearch { get; set; }
    }
}
