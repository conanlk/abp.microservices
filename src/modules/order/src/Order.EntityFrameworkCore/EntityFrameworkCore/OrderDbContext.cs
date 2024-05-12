using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Order.EntityFrameworkCore;

[ConnectionStringName(OrderDbProperties.ConnectionStringName)]
public class OrderDbContext : AbpDbContext<OrderDbContext>, IOrderDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOrder();
        builder.ConfigureTenantManagement();
        }
}
