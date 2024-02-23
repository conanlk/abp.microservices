using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.TenantManagement;

namespace Email;

[DependsOn(
    typeof(EmailDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationContractsModule))]
    public class EmailApplicationContractsModule : AbpModule
{

}
