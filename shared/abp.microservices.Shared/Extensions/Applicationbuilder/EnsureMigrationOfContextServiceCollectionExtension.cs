using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace abp.microservices.Shared.Extensions.Applicationbuilder;

public static class EnsureMigrationOfContextServiceCollectionExtension
{
    public static void EnsureMigrationOfContext<T>(this IServiceCollection services)
    where T : DbContext
    {
        var serviceProvider = services.BuildServiceProvider();
        var dbContext = serviceProvider.GetRequiredService<T>();
        dbContext.Database.Migrate();
        dbContext.Database.EnsureCreated();
    }
}