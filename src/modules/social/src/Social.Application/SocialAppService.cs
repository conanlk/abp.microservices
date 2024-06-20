using Social.Localization;
using Volo.Abp.Application.Services;

namespace Social;

public abstract class SocialAppService : ApplicationService
{
    protected SocialAppService()
    {
        LocalizationResource = typeof(SocialResource);
        ObjectMapperContext = typeof(SocialApplicationModule);
    }
}
