using Volo.Abp.Modularity;

namespace Creator;

[DependsOn(
    typeof(CreatorApplicationModule),
    typeof(CreatorDomainTestModule)
    )]
public class CreatorApplicationTestModule : AbpModule
{

}
