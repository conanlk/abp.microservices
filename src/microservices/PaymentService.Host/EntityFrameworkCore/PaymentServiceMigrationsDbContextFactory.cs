using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Payment.EntityFrameworkCore;

public class PaymentServiceMigrationsDbContextFactory : IDesignTimeDbContextFactory<PaymentServiceMigrationsDbContext>
{
    public PaymentServiceMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PaymentServiceMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Payment"));

        return new PaymentServiceMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
