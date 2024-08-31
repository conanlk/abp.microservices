using Volo.Abp.Reflection;

namespace Content.Permissions;

public class ContentPermissions
{
    public const string GroupName = "Content";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ContentPermissions));
    }
}
