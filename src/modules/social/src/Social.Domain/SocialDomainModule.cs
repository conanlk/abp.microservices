using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Social;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SocialDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class SocialDomainModule : AbpModule
{

}
