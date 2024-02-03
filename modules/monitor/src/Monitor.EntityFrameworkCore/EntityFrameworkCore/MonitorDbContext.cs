using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Monitor.EntityFrameworkCore;

[ConnectionStringName(MonitorDbProperties.ConnectionStringName)]
public class MonitorDbContext : AbpDbContext<MonitorDbContext>, IMonitorDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public MonitorDbContext(DbContextOptions<MonitorDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureMonitor();
        builder.ConfigureTenantManagement();
        }
}
