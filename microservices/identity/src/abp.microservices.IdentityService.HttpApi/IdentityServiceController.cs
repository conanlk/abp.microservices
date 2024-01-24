using abp.microservices.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp.microservices.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
