using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Wallet.EntityFrameworkCore;

[ConnectionStringName(WalletDbProperties.ConnectionStringName)]
public interface IWalletDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
