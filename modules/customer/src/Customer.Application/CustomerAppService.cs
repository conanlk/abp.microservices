using Customer.Localization;
using Volo.Abp.Application.Services;

namespace Customer;

public abstract class CustomerAppService : ApplicationService
{
    protected CustomerAppService()
    {
        LocalizationResource = typeof(CustomerResource);
        ObjectMapperContext = typeof(CustomerApplicationModule);
    }
}
