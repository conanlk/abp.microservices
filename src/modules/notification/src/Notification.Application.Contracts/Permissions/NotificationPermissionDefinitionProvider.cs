using Notification.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Notification.Permissions;

public class NotificationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NotificationPermissions.GroupName, L("Permission:Notification"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NotificationResource>(name);
    }
}
