using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Email.EntityFrameworkCore;

public class EmailHttpApiHostMigrationsDbContext : AbpDbContext<EmailHttpApiHostMigrationsDbContext>
{
    public EmailHttpApiHostMigrationsDbContext(DbContextOptions<EmailHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureEmail();
    }
}
