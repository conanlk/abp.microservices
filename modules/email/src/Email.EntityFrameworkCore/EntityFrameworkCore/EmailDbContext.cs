using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Email.EntityFrameworkCore;

[ConnectionStringName(EmailDbProperties.ConnectionStringName)]
public class EmailDbContext : AbpDbContext<EmailDbContext>, IEmailDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public EmailDbContext(DbContextOptions<EmailDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureEmail();
        builder.ConfigureTenantManagement();
        }
}
