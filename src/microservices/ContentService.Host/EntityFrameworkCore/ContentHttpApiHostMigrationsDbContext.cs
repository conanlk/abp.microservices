using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Content.EntityFrameworkCore;

public class ContentHttpApiHostMigrationsDbContext : AbpDbContext<ContentHttpApiHostMigrationsDbContext>
{
    public ContentHttpApiHostMigrationsDbContext(DbContextOptions<ContentHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureContent();
    }
}
