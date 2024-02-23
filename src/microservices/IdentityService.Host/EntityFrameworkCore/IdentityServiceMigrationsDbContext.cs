using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Identity.EntityFrameworkCore;

public class IdentityServiceMigrationsDbContext : AbpDbContext<IdentityServiceMigrationsDbContext>
{
    public IdentityServiceMigrationsDbContext(DbContextOptions<IdentityServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureIdentity();
    }
}
