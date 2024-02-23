using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace abp.microservices.Shared.Extentions;

public static class AddMigrationDbContextCollectionExtension
{
    public static IServiceCollection AddMigrationDbContext<T>( this IServiceCollection services) where T:AbpDbContext<T>
    {
        services.AddAbpDbContext<T>();
        return services;
    }
}