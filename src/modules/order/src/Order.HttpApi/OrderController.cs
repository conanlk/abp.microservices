using Order.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Order;

public abstract class OrderController : AbpControllerBase
{
    protected OrderController()
    {
        LocalizationResource = typeof(OrderResource);
    }
}
