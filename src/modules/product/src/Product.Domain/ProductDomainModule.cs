using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Product;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProductDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class ProductDomainModule : AbpModule
{

}
