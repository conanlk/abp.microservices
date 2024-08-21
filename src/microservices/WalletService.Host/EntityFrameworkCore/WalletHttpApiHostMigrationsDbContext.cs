using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Wallet.EntityFrameworkCore;

public class WalletHttpApiHostMigrationsDbContext : AbpDbContext<WalletHttpApiHostMigrationsDbContext>
{
    public WalletHttpApiHostMigrationsDbContext(DbContextOptions<WalletHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureWallet();
    }
}
