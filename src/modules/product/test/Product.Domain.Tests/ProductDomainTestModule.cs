using Volo.Abp.Modularity;

namespace Product;

[DependsOn(
    typeof(ProductDomainModule),
    typeof(ProductTestBaseModule)
)]
public class ProductDomainTestModule : AbpModule
{

}
