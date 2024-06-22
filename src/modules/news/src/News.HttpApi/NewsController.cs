using News.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace News;

public abstract class NewsController : AbpControllerBase
{
    protected NewsController()
    {
        LocalizationResource = typeof(NewsResource);
    }
}
