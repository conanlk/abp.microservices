using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Monitor.EntityFrameworkCore;

public class MonitorServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<MonitorServiceMigrationsDbContext>
{
    public MonitorServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MonitorServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Monitor"));

        return new MonitorServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
