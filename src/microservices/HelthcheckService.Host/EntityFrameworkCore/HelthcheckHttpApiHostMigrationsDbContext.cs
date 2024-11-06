using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Helthcheck.EntityFrameworkCore;

public class HelthcheckHttpApiHostMigrationsDbContext : AbpDbContext<HelthcheckHttpApiHostMigrationsDbContext>
{
    public HelthcheckHttpApiHostMigrationsDbContext(DbContextOptions<HelthcheckHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureHelthcheck();
    }
}
