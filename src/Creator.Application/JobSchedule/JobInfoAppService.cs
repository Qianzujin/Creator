using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using AutoMapper;

namespace Creator.JobSchedule
{
    public class JobInfoService :
           CrudAppService<
               JobInfo, //The Book entity
               JobInfoDto, //Used to show books
               Guid, //Primary key of the book entity
               PagedAndSortedResultRequestDto, //Used for paging/sorting
               CreateUpdateJobInfoDto>, //Used to create/update a book
           IJobInfoAppService //implement the IBookAppService
    {
        private readonly IRepository<JobInfo, Guid> _repository;
        public JobInfoService(IRepository<JobInfo, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public List<JobInfoDto> GetListByJobStatuAsync(JobStatu jobStatu)
        {
            var result = _repository.GetListAsync();
            for (int i = 0; i < result.Result.Count; i++)
            {
                var r = result.Result[i];
            }
            return null;
        }
    }
}