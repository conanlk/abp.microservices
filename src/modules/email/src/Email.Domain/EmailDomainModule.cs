using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Email;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(EmailDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class EmailDomainModule : AbpModule
{

}
