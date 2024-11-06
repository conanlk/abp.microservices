using Volo.Abp.Reflection;

namespace Helthcheck.Permissions;

public class HelthcheckPermissions
{
    public const string GroupName = "Helthcheck";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(HelthcheckPermissions));
    }
}
