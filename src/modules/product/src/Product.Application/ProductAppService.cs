using Product.Localization;
using Volo.Abp.Application.Services;

namespace Product;

public abstract class ProductAppService : ApplicationService
{
    protected ProductAppService()
    {
        LocalizationResource = typeof(ProductResource);
        ObjectMapperContext = typeof(ProductApplicationModule);
    }
}
