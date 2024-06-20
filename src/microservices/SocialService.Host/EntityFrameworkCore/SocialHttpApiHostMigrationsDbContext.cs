using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Social.EntityFrameworkCore;

public class SocialHttpApiHostMigrationsDbContext : AbpDbContext<SocialHttpApiHostMigrationsDbContext>
{
    public SocialHttpApiHostMigrationsDbContext(DbContextOptions<SocialHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureSocial();
    }
}
