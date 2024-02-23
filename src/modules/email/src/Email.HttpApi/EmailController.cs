using Email.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Email;

public abstract class EmailController : AbpControllerBase
{
    protected EmailController()
    {
        LocalizationResource = typeof(EmailResource);
    }
}
