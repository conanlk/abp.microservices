using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.TenantManagement;

namespace Notification;

[DependsOn(
    typeof(NotificationDomainModule),
    typeof(NotificationApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationModule))]
    public class NotificationApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<NotificationApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NotificationApplicationModule>(validate: true);
        });
    }
}
