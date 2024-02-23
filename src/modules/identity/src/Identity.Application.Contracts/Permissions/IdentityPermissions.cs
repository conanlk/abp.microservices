using Volo.Abp.Reflection;

namespace Identity.Permissions;

public class IdentityPermissions
{
    public const string GroupName = "Identity";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(IdentityPermissions));
    }
}
