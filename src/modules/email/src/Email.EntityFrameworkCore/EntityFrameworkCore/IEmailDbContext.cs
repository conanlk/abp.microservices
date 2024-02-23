using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Email.EntityFrameworkCore;

[ConnectionStringName(EmailDbProperties.ConnectionStringName)]
public interface IEmailDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
