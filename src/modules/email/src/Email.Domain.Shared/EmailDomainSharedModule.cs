using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Email.Localization;
using Volo.Abp.Domain;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.TenantManagement;

namespace Email;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(AbpDddDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainSharedModule))]
    public class EmailDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<EmailDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<EmailResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/Email");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("Email", typeof(EmailResource));
        });
    }
}
