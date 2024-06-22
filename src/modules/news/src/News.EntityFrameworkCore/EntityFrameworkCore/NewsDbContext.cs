using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace News.EntityFrameworkCore;

[ConnectionStringName(NewsDbProperties.ConnectionStringName)]
public class NewsDbContext : AbpDbContext<NewsDbContext>, INewsDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public NewsDbContext(DbContextOptions<NewsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureNews();
        builder.ConfigureTenantManagement();
        }
}
