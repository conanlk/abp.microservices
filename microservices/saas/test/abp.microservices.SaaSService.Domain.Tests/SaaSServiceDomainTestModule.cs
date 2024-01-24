using Volo.Abp.Modularity;

namespace abp.microservices.SaaSService;

[DependsOn(
    typeof(SaaSServiceDomainModule),
    typeof(SaaSServiceTestBaseModule)
)]
public class SaaSServiceDomainTestModule : AbpModule
{

}
