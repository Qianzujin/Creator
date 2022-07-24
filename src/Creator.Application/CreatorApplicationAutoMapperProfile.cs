using AutoMapper;

using Creator.JobSchedule;

namespace Creator;

public class CreatorApplicationAutoMapperProfile : Profile
{
    public CreatorApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<JobInfo, JobInfoDto>();
        CreateMap<CreateUpdateJobInfoDto, JobInfo>();

    }
}
