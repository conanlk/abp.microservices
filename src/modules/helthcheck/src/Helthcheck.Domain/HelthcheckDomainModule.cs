using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Helthcheck;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(HelthcheckDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class HelthcheckDomainModule : AbpModule
{

}
