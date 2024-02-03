using Volo.Abp.Reflection;

namespace Customer.Permissions;

public class CustomerPermissions
{
    public const string GroupName = "Customer";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerPermissions));
    }
}
