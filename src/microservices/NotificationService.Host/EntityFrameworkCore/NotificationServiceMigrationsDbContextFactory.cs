using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Notification.EntityFrameworkCore;

public class NotificationServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<NotificationServiceMigrationsDbContext>
{
    public NotificationServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NotificationServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Notification"));

        return new NotificationServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
