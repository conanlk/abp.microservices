using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.TenantManagement;

namespace Email;

[DependsOn(
    typeof(EmailApplicationContractsModule),
    typeof(AbpHttpClientModule))]
[DependsOn(typeof(AbpTenantManagementHttpApiClientModule))]
    public class EmailHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(EmailApplicationContractsModule).Assembly,
            EmailRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<EmailHttpApiClientModule>();
        });

    }
}
