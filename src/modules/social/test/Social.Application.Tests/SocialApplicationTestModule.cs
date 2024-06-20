using Volo.Abp.Modularity;

namespace Social;

[DependsOn(
    typeof(SocialApplicationModule),
    typeof(SocialDomainTestModule)
    )]
public class SocialApplicationTestModule : AbpModule
{

}
