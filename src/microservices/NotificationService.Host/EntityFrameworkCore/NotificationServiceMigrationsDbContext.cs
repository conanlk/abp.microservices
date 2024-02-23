using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Notification.EntityFrameworkCore;

public class NotificationServiceMigrationsDbContext : AbpDbContext<NotificationServiceMigrationsDbContext>
{
    public NotificationServiceMigrationsDbContext(DbContextOptions<NotificationServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureNotification();
    }
}
