using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Monitor.EntityFrameworkCore;

public class MonitorServiceMigrationsDbContext : AbpDbContext<MonitorServiceMigrationsDbContext>
{
    public MonitorServiceMigrationsDbContext(DbContextOptions<MonitorServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureMonitor();
    }
}
