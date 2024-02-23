using Notification.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Notification;

public abstract class NotificationController : AbpControllerBase
{
    protected NotificationController()
    {
        LocalizationResource = typeof(NotificationResource);
    }
}
