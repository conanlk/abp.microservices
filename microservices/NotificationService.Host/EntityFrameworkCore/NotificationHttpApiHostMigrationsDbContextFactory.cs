using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Notification.EntityFrameworkCore;

public class NotificationHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<NotificationHttpApiHostMigrationsDbContext>
{
    public NotificationHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NotificationHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Notification"));

        return new NotificationHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
