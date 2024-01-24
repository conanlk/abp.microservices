using abp.microservices.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp.microservices.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
