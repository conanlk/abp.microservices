using News.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace News.Permissions;

public class NewsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NewsPermissions.GroupName, L("Permission:News"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NewsResource>(name);
    }
}
