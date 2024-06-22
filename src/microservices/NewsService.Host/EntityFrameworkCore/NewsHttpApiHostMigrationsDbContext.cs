using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace News.EntityFrameworkCore;

public class NewsHttpApiHostMigrationsDbContext : AbpDbContext<NewsHttpApiHostMigrationsDbContext>
{
    public NewsHttpApiHostMigrationsDbContext(DbContextOptions<NewsHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureNews();
    }
}
