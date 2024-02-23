using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Monitor.EntityFrameworkCore;

[ConnectionStringName(MonitorDbProperties.ConnectionStringName)]
public interface IMonitorDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
