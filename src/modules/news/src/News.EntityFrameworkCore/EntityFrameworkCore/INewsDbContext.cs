using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace News.EntityFrameworkCore;

[ConnectionStringName(NewsDbProperties.ConnectionStringName)]
public interface INewsDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
