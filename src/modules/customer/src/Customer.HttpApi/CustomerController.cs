using Customer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Customer;

public abstract class CustomerController : AbpControllerBase
{
    protected CustomerController()
    {
        LocalizationResource = typeof(CustomerResource);
    }
}
