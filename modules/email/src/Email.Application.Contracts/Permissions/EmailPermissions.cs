using Volo.Abp.Reflection;

namespace Email.Permissions;

public class EmailPermissions
{
    public const string GroupName = "Email";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(EmailPermissions));
    }
}
