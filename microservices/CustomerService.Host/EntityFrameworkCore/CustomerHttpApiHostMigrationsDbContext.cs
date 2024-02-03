using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Customer.EntityFrameworkCore;

public class CustomerHttpApiHostMigrationsDbContext : AbpDbContext<CustomerHttpApiHostMigrationsDbContext>
{
    public CustomerHttpApiHostMigrationsDbContext(DbContextOptions<CustomerHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureCustomer();
    }
}
