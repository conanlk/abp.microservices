using Volo.Abp.Modularity;

namespace News;

[DependsOn(
    typeof(NewsDomainModule),
    typeof(NewsTestBaseModule)
)]
public class NewsDomainTestModule : AbpModule
{

}
