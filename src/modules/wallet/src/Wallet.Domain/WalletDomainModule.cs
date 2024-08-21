using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Wallet;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(WalletDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class WalletDomainModule : AbpModule
{

}
