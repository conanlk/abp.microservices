using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Content.EntityFrameworkCore;

[ConnectionStringName(ContentDbProperties.ConnectionStringName)]
public interface IContentDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
