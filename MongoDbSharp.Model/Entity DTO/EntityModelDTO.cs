using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Model.Entity_DTO
{
    namespace MongoDbSharp.DTOs
    {
        public class EntityModelDTO
        {
            public string Id { get; set; }
            public List<JobInformationDTO> JobInformations { get; set; }
            public int P_ID { get; set; }
            public int MaxApplyId { get; set; }
            public string Name { get; set; }
            public string MOBILE { get; set; }
            public string HOME_PHONE { get; set; }
            public string Gender { get; set; }
            public DateTime? BIRTH { get; set; }
            public bool AttachCV { get; set; }
            public bool VDOCV { get; set; }
            public string FileType { get; set; }
            public string Email { get; set; }
            public int CurrentSalary { get; set; }
            public string PREF { get; set; }
            public int Texp { get; set; }
            public string UserLocation { get; set; }
            public string ParmanentAddress { get; set; }
            public bool PhotoUploaded { get; set; }
            public string PhotoName { get; set; }
            public string? InstituteName { get; set; }
            public string? DegreeName { get; set; }
            public DateTime CreatedOn { get; set; }
            public DateTime LastUpdatedOn { get; set; }
            public List<ApplicantSkillsDTO> Skills { get; set; }
            public List<ApplicantsExperinceListDTO> SearchExperinceList { get; set; }
            public ExprienceCardViewDataDTO Card1ExperienceData { get; set; }
            public ExprienceCardViewDataDTO Card2ExperienceData { get; set; }
            public List<EducationInfoDTO> EducationList { get; set; }
            public string KeywordSearch { get; set; }
        }
    }
}


