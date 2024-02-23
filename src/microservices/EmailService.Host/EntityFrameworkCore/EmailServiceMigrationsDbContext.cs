using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Email.EntityFrameworkCore;

public class EmailServiceMigrationsDbContext : AbpDbContext<EmailServiceMigrationsDbContext>
{
    public EmailServiceMigrationsDbContext(DbContextOptions<EmailServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureEmail();
    }
}
