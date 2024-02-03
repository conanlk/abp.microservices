using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.TenantManagement;

namespace Monitor;

[DependsOn(
    typeof(MonitorDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationContractsModule))]
    public class MonitorApplicationContractsModule : AbpModule
{

}
