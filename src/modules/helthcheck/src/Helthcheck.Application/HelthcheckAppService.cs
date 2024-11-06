using Helthcheck.Localization;
using Volo.Abp.Application.Services;

namespace Helthcheck;

public abstract class HelthcheckAppService : ApplicationService
{
    protected HelthcheckAppService()
    {
        LocalizationResource = typeof(HelthcheckResource);
        ObjectMapperContext = typeof(HelthcheckApplicationModule);
    }
}
