using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Customer.EntityFrameworkCore;

[ConnectionStringName(CustomerDbProperties.ConnectionStringName)]
public interface ICustomerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
