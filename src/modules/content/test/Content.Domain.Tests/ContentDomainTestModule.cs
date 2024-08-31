using Volo.Abp.Modularity;

namespace Content;

[DependsOn(
    typeof(ContentDomainModule),
    typeof(ContentTestBaseModule)
)]
public class ContentDomainTestModule : AbpModule
{

}
