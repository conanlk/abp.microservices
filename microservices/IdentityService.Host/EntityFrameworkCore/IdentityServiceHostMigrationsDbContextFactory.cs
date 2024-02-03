using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IdentityService.Host.EntityFrameworkCore;

public class IdentityServiceHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<IdentityServiceHostMigrationsDbContext>
{
    public IdentityServiceHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IdentityServiceHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Identity"));

        return new IdentityServiceHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
