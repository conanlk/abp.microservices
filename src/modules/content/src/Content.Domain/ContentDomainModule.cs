using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Content;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ContentDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class ContentDomainModule : AbpModule
{

}
