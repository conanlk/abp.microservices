using Volo.Abp.Modularity;

namespace Customer;

[DependsOn(
    typeof(CustomerApplicationModule),
    typeof(CustomerDomainTestModule)
    )]
public class CustomerApplicationTestModule : AbpModule
{

}
