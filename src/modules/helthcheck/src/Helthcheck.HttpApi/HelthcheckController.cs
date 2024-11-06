using Helthcheck.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Helthcheck;

public abstract class HelthcheckController : AbpControllerBase
{
    protected HelthcheckController()
    {
        LocalizationResource = typeof(HelthcheckResource);
    }
}
