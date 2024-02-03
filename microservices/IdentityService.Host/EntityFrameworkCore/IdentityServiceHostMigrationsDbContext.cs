using Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace IdentityService.Host.EntityFrameworkCore;

public class IdentityServiceHostMigrationsDbContext : AbpDbContext<IdentityServiceHostMigrationsDbContext>
{
    public IdentityServiceHostMigrationsDbContext(DbContextOptions<IdentityServiceHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureIdentity();
    }
}
