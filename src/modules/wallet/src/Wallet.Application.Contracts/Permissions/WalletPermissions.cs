using Volo.Abp.Reflection;

namespace Wallet.Permissions;

public class WalletPermissions
{
    public const string GroupName = "Wallet";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(WalletPermissions));
    }
}
