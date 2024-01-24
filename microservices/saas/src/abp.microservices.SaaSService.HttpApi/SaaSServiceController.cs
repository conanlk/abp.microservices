using abp.microservices.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp.microservices.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
