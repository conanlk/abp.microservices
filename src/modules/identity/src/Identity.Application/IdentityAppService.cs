using Identity.Localization;
using Volo.Abp.Application.Services;

namespace Identity;

public abstract class IdentityAppService : ApplicationService
{
    protected IdentityAppService()
    {
        LocalizationResource = typeof(IdentityResource);
        ObjectMapperContext = typeof(IdentityApplicationModule);
    }
}
