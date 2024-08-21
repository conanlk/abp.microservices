using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Wallet.EntityFrameworkCore;

[ConnectionStringName(WalletDbProperties.ConnectionStringName)]
public class WalletDbContext : AbpDbContext<WalletDbContext>, IWalletDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public WalletDbContext(DbContextOptions<WalletDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureWallet();
        builder.ConfigureTenantManagement();
        }
}
