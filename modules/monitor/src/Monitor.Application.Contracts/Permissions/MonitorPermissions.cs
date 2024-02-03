using Volo.Abp.Reflection;

namespace Monitor.Permissions;

public class MonitorPermissions
{
    public const string GroupName = "Monitor";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MonitorPermissions));
    }
}
