using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Customer.EntityFrameworkCore;

public class CustomerServiceMigrationsDbContext : AbpDbContext<CustomerServiceMigrationsDbContext>
{
    public CustomerServiceMigrationsDbContext(DbContextOptions<CustomerServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureCustomer();
    }
}
