using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.TenantManagement;

namespace Notification;

[DependsOn(
    typeof(NotificationDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationContractsModule))]
    public class NotificationApplicationContractsModule : AbpModule
{

}
