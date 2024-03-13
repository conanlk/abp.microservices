using Volo.Abp.Modularity;

namespace Product;

[DependsOn(
    typeof(ProductApplicationModule),
    typeof(ProductDomainTestModule)
    )]
public class ProductApplicationTestModule : AbpModule
{

}
