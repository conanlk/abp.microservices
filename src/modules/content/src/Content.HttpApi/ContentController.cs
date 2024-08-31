using Content.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Content;

public abstract class ContentController : AbpControllerBase
{
    protected ContentController()
    {
        LocalizationResource = typeof(ContentResource);
    }
}
