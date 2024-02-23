using Monitor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Monitor.Permissions;

public class MonitorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MonitorPermissions.GroupName, L("Permission:Monitor"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MonitorResource>(name);
    }
}
