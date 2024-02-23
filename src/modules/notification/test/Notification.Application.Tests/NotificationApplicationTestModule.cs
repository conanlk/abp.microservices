using Volo.Abp.Modularity;

namespace Notification;

[DependsOn(
    typeof(NotificationApplicationModule),
    typeof(NotificationDomainTestModule)
    )]
public class NotificationApplicationTestModule : AbpModule
{

}
