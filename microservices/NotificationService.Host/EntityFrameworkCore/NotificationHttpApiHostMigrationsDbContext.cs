using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Notification.EntityFrameworkCore;

public class NotificationHttpApiHostMigrationsDbContext : AbpDbContext<NotificationHttpApiHostMigrationsDbContext>
{
    public NotificationHttpApiHostMigrationsDbContext(DbContextOptions<NotificationHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureNotification();
    }
}
