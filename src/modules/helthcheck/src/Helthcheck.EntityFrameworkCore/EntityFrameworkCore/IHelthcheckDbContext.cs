using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Helthcheck.EntityFrameworkCore;

[ConnectionStringName(HelthcheckDbProperties.ConnectionStringName)]
public interface IHelthcheckDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
