using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Notification;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NotificationHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class NotificationConsoleApiClientModule : AbpModule
{

}
