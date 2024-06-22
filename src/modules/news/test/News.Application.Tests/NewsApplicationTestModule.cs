using Volo.Abp.Modularity;

namespace News;

[DependsOn(
    typeof(NewsApplicationModule),
    typeof(NewsDomainTestModule)
    )]
public class NewsApplicationTestModule : AbpModule
{

}
