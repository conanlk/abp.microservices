using Social.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Social.Permissions;

public class SocialPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SocialPermissions.GroupName, L("Permission:Social"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SocialResource>(name);
    }
}
