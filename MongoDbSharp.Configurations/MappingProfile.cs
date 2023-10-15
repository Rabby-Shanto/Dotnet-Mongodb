using AutoMapper;
using MongoDbSharp.Model.Entity_DTO.MongoDbSharp.DTOs;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EntityModelDTO,EntityModel>();
            CreateMap<JobInformationDTO,JobInformation>();
            CreateMap<ApplicantProcessInfoDTO,ApplicantProcessInfo>();
            CreateMap<CommentsDataDTO, CommentsData>();
            CreateMap<ApplicantSkillsDTO,ApplicantSkills > ();
            CreateMap<ApplicantsExperinceListDTO, ApplicantsExperinceList>();
            CreateMap<ExprienceCardViewDataDTO, ExprienceCardViewData>();
            CreateMap<EducationInfoDTO, EducationInfo>();
        }

    }
}
