using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace abp.microservices.SaaSService.EntityFrameworkCore;

public class SaaSServiceHttpApiHostMigrationsDbContext : AbpDbContext<SaaSServiceHttpApiHostMigrationsDbContext>
{
    public SaaSServiceHttpApiHostMigrationsDbContext(DbContextOptions<SaaSServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureSaaSService();
    }
}
