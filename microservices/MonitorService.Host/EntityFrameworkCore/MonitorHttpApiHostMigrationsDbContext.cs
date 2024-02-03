using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Monitor.EntityFrameworkCore;

public class MonitorHttpApiHostMigrationsDbContext : AbpDbContext<MonitorHttpApiHostMigrationsDbContext>
{
    public MonitorHttpApiHostMigrationsDbContext(DbContextOptions<MonitorHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureMonitor();
    }
}
