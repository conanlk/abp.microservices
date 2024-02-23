using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Email.EntityFrameworkCore;

public class EmailServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<EmailServiceMigrationsDbContext>
{
    public EmailServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EmailServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Email"));

        return new EmailServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
