using Volo.Abp.Modularity;

namespace Customer;

[DependsOn(
    typeof(CustomerDomainModule),
    typeof(CustomerTestBaseModule)
)]
public class CustomerDomainTestModule : AbpModule
{

}
