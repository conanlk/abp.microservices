using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Monitor.EntityFrameworkCore;

[DependsOn(
    typeof(MonitorDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
[DependsOn(typeof(AbpTenantManagementEntityFrameworkCoreModule))]
    public class MonitorEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<MonitorDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
