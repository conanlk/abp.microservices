using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.TenantManagement;

namespace Customer;

[DependsOn(
    typeof(CustomerDomainModule),
    typeof(CustomerApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpTenantManagementApplicationModule))]
    public class CustomerApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<CustomerApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CustomerApplicationModule>(validate: true);
        });
    }
}
