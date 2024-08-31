using Volo.Abp.Modularity;

namespace Content;

[DependsOn(
    typeof(ContentApplicationModule),
    typeof(ContentDomainTestModule)
    )]
public class ContentApplicationTestModule : AbpModule
{

}
