using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Payment.EntityFrameworkCore;

[DependsOn(
    typeof(PaymentDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
[DependsOn(typeof(AbpTenantManagementEntityFrameworkCoreModule))]
    public class PaymentEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<PaymentDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
