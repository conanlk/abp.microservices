using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.TenantManagement;

namespace Notification;

[DependsOn(
    typeof(NotificationApplicationContractsModule),
    typeof(AbpHttpClientModule))]
[DependsOn(typeof(AbpTenantManagementHttpApiClientModule))]
    public class NotificationHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(NotificationApplicationContractsModule).Assembly,
            NotificationRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NotificationHttpApiClientModule>();
        });

    }
}
