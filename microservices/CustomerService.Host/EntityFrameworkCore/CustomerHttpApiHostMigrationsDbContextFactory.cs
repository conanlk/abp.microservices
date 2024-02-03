using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CustomerService.Host.EntityFrameworkCore;

public class CustomerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<CustomerHttpApiHostMigrationsDbContext>
{
    public CustomerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CustomerHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Customer"));

        return new CustomerHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
