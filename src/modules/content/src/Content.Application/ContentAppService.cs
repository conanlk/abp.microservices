using Content.Localization;
using Volo.Abp.Application.Services;

namespace Content;

public abstract class ContentAppService : ApplicationService
{
    protected ContentAppService()
    {
        LocalizationResource = typeof(ContentResource);
        ObjectMapperContext = typeof(ContentApplicationModule);
    }
}
