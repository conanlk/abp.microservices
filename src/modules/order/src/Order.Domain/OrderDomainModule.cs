using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Order;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrderDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class OrderDomainModule : AbpModule
{

}
