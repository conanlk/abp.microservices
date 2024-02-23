using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Email.EntityFrameworkCore;

[DependsOn(
    typeof(EmailDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
[DependsOn(typeof(AbpTenantManagementEntityFrameworkCoreModule))]
    public class EmailEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<EmailDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
