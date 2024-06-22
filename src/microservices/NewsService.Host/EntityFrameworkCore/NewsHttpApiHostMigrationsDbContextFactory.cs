using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace News.EntityFrameworkCore;

public class NewsHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<NewsHttpApiHostMigrationsDbContext>
{
    public NewsHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NewsHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("News"));

        return new NewsHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
