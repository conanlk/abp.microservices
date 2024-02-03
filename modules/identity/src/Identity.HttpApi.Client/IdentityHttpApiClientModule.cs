using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Identity;

namespace Identity;

[DependsOn(
    typeof(IdentityApplicationContractsModule),
    typeof(AbpHttpClientModule))]
[DependsOn(typeof(AbpIdentityHttpApiClientModule))]
    public class IdentityHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(IdentityApplicationContractsModule).Assembly,
            IdentityRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<IdentityHttpApiClientModule>();
        });

    }
}
