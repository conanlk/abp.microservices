using Helthcheck.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Helthcheck.Permissions;

public class HelthcheckPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HelthcheckPermissions.GroupName, L("Permission:Helthcheck"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HelthcheckResource>(name);
    }
}
