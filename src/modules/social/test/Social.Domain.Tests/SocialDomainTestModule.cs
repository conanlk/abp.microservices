using Volo.Abp.Modularity;

namespace Social;

[DependsOn(
    typeof(SocialDomainModule),
    typeof(SocialTestBaseModule)
)]
public class SocialDomainTestModule : AbpModule
{

}
