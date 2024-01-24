using Volo.Abp.Modularity;

namespace abp.microservices.SaaSService;

[DependsOn(
    typeof(SaaSServiceApplicationModule),
    typeof(SaaSServiceDomainTestModule)
    )]
public class SaaSServiceApplicationTestModule : AbpModule
{

}
