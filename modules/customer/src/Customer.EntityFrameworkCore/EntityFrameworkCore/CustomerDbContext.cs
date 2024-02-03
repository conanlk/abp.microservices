using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Customer.EntityFrameworkCore;

[ConnectionStringName(CustomerDbProperties.ConnectionStringName)]
public class CustomerDbContext : AbpDbContext<CustomerDbContext>, ICustomerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCustomer();
        builder.ConfigureTenantManagement();
        }
}
