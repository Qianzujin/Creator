using Creator.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Creator.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CreatorEntityFrameworkCoreModule),
    typeof(CreatorApplicationContractsModule)
    )]
public class CreatorDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
