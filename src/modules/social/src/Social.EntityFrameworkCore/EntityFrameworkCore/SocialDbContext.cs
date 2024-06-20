using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Social.EntityFrameworkCore;

[ConnectionStringName(SocialDbProperties.ConnectionStringName)]
public class SocialDbContext : AbpDbContext<SocialDbContext>, ISocialDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public SocialDbContext(DbContextOptions<SocialDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSocial();
        builder.ConfigureTenantManagement();
        }
}
