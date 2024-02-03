using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Monitor.EntityFrameworkCore;

public class MonitorHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MonitorHttpApiHostMigrationsDbContext>
{
    public MonitorHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MonitorHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Monitor"));

        return new MonitorHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
