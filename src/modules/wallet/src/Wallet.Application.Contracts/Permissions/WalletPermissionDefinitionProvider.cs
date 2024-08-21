using Wallet.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Wallet.Permissions;

public class WalletPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WalletPermissions.GroupName, L("Permission:Wallet"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WalletResource>(name);
    }
}
