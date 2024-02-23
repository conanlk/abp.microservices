using Identity.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Identity;

public abstract class IdentityController : AbpControllerBase
{
    protected IdentityController()
    {
        LocalizationResource = typeof(IdentityResource);
    }
}
