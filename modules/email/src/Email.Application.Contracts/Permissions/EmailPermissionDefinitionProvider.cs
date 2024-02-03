using Email.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Email.Permissions;

public class EmailPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmailPermissions.GroupName, L("Permission:Email"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmailResource>(name);
    }
}
