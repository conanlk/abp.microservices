using Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Product;

public abstract class ProductController : AbpControllerBase
{
    protected ProductController()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
