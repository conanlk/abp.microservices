using Notification.Localization;
using Volo.Abp.Application.Services;

namespace Notification;

public abstract class NotificationAppService : ApplicationService
{
    protected NotificationAppService()
    {
        LocalizationResource = typeof(NotificationResource);
        ObjectMapperContext = typeof(NotificationApplicationModule);
    }
}
