using Volo.Abp.Reflection;

namespace Social.Permissions;

public class SocialPermissions
{
    public const string GroupName = "Social";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SocialPermissions));
    }
}
