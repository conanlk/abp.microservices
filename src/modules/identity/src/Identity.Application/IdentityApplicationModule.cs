using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Identity;

namespace Identity;

[DependsOn(
    typeof(IdentityDomainModule),
    typeof(IdentityApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpIdentityApplicationModule))]
    public class IdentityApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<IdentityApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<IdentityApplicationModule>(validate: true);
        });
    }
}
