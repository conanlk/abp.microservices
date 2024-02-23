using Localization.Resources.AbpUi;
using Monitor.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.TenantManagement;

namespace Monitor;

[DependsOn(
    typeof(MonitorApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
[DependsOn(typeof(AbpTenantManagementHttpApiModule))]
    public class MonitorHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(MonitorHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MonitorResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
