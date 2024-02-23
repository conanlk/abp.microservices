using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Monitor;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MonitorDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
    public class MonitorDomainModule : AbpModule
{

}
