using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Notification.EntityFrameworkCore;

[ConnectionStringName(NotificationDbProperties.ConnectionStringName)]
public interface INotificationDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
