using Content.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Content.Permissions;

public class ContentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ContentPermissions.GroupName, L("Permission:Content"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ContentResource>(name);
    }
}
