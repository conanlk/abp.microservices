using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Social.EntityFrameworkCore;

[ConnectionStringName(SocialDbProperties.ConnectionStringName)]
public interface ISocialDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
