using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace abp.microservices.Shared.Extentions.ApplicationBuilder;

public static class EnsureMigrationOfContextServiceCollectionExtension
{
    public static void EnsureMigrationOfContext<T>(this IServiceCollection services)
        where T : Microsoft.EntityFrameworkCore.DbContext
    {
        var serviceProvider = services.BuildServiceProvider();
        var dbContext = serviceProvider.GetRequiredService<T>();
        // Run migrations
        dbContext.Database.Migrate();
        // Ensure database is created
        dbContext.Database.EnsureCreated();
    }
}