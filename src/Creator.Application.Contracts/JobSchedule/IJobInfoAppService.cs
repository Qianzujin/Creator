using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Creator.JobSchedule
{
    public interface IJobInfoAppService :
        ICrudAppService< //Defines CRUD methods
            JobInfoDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateJobInfoDto> //Used to create/update a book
    {
        List<JobInfoDto> GetListByJobStatuAsync(JobStatu jobStatu);

    }
}
