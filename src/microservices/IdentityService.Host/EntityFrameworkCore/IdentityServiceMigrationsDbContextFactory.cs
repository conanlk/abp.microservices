using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Identity.EntityFrameworkCore;

public class IdentityServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<IdentityServiceMigrationsDbContext>
{
    public IdentityServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IdentityServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Identity"));

        return new IdentityServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
