using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Notification;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(NotificationDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class NotificationDomainModule : AbpModule
{

}
