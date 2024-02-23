using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.TenantManagement;

namespace Email;

[DependsOn(
    typeof(EmailDomainModule),
    typeof(EmailApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationModule))]
    public class EmailApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<EmailApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<EmailApplicationModule>(validate: true);
        });
    }
}
