using Volo.Abp.Modularity;

namespace Notification;

[DependsOn(
    typeof(NotificationDomainModule),
    typeof(NotificationTestBaseModule)
)]
public class NotificationDomainTestModule : AbpModule
{

}
