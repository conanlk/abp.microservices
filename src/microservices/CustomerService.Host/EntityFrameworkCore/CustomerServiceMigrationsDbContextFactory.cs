using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Customer.EntityFrameworkCore;

public class CustomerServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<CustomerServiceMigrationsDbContext>
{
    public CustomerServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CustomerServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Customer"));

        return new CustomerServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
