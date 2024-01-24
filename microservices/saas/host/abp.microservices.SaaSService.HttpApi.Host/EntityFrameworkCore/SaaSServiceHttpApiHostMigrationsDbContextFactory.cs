using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abp.microservices.SaaSService.EntityFrameworkCore;

public class SaaSServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SaaSServiceHttpApiHostMigrationsDbContext>
{
    public SaaSServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SaaSServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("SaaSService"));

        return new SaaSServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
