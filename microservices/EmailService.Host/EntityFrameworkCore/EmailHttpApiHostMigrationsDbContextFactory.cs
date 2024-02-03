using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Email.EntityFrameworkCore;

public class EmailHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<EmailHttpApiHostMigrationsDbContext>
{
    public EmailHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EmailHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Email"));

        return new EmailHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
