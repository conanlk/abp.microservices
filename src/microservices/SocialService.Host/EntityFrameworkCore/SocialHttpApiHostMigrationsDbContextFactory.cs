using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Social.EntityFrameworkCore;

public class SocialHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SocialHttpApiHostMigrationsDbContext>
{
    public SocialHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SocialHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Social"));

        return new SocialHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
