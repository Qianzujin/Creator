using Creator.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Creator;

[DependsOn(
    typeof(CreatorEntityFrameworkCoreTestModule)
    )]
public class CreatorDomainTestModule : AbpModule
{

}
