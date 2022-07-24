using System;
using System.Threading.Tasks;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Creator.JobSchedule
{
    public class JobInfoDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<JobInfo, Guid> _jobInfoRepository;

        public JobInfoDataSeederContributor(IRepository<JobInfo, Guid> jobInfoRepository)
        {
            _jobInfoRepository = jobInfoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _jobInfoRepository.GetCountAsync() <= 0)
            {
                await _jobInfoRepository.InsertAsync(
                    new JobInfo
                    {
                        JobName = "测试",
                        JobStatus = JobStatu.Stopped,
                        CronExpress = "测试",
                        JobAssemblyName = "测试",
                        JobClassName = "测试",
                        JobDescription = "测试",
                        JobGroup =  "测试",
                        JobNamespace = "测试"
                    },
                    autoSave: true
                );
            }
        }
    }
}