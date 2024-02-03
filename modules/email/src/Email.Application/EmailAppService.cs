using Email.Localization;
using Volo.Abp.Application.Services;

namespace Email;

public abstract class EmailAppService : ApplicationService
{
    protected EmailAppService()
    {
        LocalizationResource = typeof(EmailResource);
        ObjectMapperContext = typeof(EmailApplicationModule);
    }
}
