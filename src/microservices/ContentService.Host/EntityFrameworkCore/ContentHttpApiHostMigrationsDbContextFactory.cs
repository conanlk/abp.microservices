using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Content.EntityFrameworkCore;

public class ContentHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ContentHttpApiHostMigrationsDbContext>
{
    public ContentHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ContentHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Content"));

        return new ContentHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
