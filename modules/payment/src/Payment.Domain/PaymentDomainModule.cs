using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Payment;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PaymentDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class PaymentDomainModule : AbpModule
{

}
