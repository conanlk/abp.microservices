using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Notification.EntityFrameworkCore;

[ConnectionStringName(NotificationDbProperties.ConnectionStringName)]
public class NotificationDbContext : AbpDbContext<NotificationDbContext>, INotificationDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public NotificationDbContext(DbContextOptions<NotificationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureNotification();
        builder.ConfigureTenantManagement();
        }
}
