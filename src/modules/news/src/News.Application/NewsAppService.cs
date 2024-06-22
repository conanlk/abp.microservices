using News.Localization;
using Volo.Abp.Application.Services;

namespace News;

public abstract class NewsAppService : ApplicationService
{
    protected NewsAppService()
    {
        LocalizationResource = typeof(NewsResource);
        ObjectMapperContext = typeof(NewsApplicationModule);
    }
}
