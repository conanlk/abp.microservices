using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Customer;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CustomerDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class CustomerDomainModule : AbpModule
{

}
