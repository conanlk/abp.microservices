using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Helthcheck.EntityFrameworkCore;

public class HelthcheckHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<HelthcheckHttpApiHostMigrationsDbContext>
{
    public HelthcheckHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HelthcheckHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Helthcheck"));

        return new HelthcheckHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
