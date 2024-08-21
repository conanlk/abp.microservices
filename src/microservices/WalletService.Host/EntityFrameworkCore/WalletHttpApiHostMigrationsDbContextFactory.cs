using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Wallet.EntityFrameworkCore;

public class WalletHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<WalletHttpApiHostMigrationsDbContext>
{
    public WalletHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<WalletHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Wallet"));

        return new WalletHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
