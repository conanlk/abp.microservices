using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Content.EntityFrameworkCore;

[ConnectionStringName(ContentDbProperties.ConnectionStringName)]
public class ContentDbContext : AbpDbContext<ContentDbContext>, IContentDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ContentDbContext(DbContextOptions<ContentDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureContent();
        builder.ConfigureTenantManagement();
        }
}
