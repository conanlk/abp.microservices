using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;

namespace Identity.EntityFrameworkCore;

[DependsOn(
    typeof(IdentityDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
[DependsOn(typeof(AbpIdentityEntityFrameworkCoreModule))]
    [DependsOn(typeof(AbpIdentityServerEntityFrameworkCoreModule))]
    public class IdentityEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<IdentityDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
