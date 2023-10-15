using MongoDB.Bson;

namespace MongoDbSharp.Model
{
    public class JobInformation 
    {
        public int ApplyID { get; set; }
        public int JP_ID { get; set; }
        public int CP_ID { get; set; }
        public int TApply { get; set; }
        public DateTime? P_Date { get; set; }
        public int ExpectedSalary { get; set; }
        public bool Viewed { get; set; }
        public bool Rejected { get; set; }
        public string MatchingPoint { get; set; }
        public int HiestLevel { get; set; }
        public int CommentsCount { get; set; }
        public int PurchaseID { get; set; }
        public string FollowedEmployer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public List<ApplicantProcessInfo> ApplicantProcessInfo { get; set; }
        public List<CommentsData> CommentsData { get; set; }
    }
}
