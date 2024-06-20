using Social.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Social;

public abstract class SocialController : AbpControllerBase
{
    protected SocialController()
    {
        LocalizationResource = typeof(SocialResource);
    }
}
