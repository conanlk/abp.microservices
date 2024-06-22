using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace News;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(NewsDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class NewsDomainModule : AbpModule
{

}
