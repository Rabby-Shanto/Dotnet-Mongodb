namespace MongoDbSharp.Model.DTO
{
    public class EntityListDto
    {
        public int P_ID { get; set; }
        public string Name { get; set; }
        public string MOBILE { get; set; }
        public string UserLocation { get; set; }
        public int TApply { get; set; } //Count(Apply _ times)
        public string MatchingPoint { get; set; }
        public string EDUCATION { get; set; }
        public string INSTITUTE { get; set; }
        public int Texp { get; set; }
        public List<JobInformation> jobInformations { get; set; }
        public List<EducationInfo> EducationList { get; set; }
        public ExprienceCardViewData? Card2ExperienceData { get; set; }
    }
}
