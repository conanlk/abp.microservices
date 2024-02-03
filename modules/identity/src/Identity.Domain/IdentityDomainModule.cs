using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.IdentityServer;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;

namespace Identity;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(IdentityDomainSharedModule)
)]
[DependsOn(typeof(AbpIdentityDomainModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainIdentityModule))]
    [DependsOn(typeof(AbpIdentityServerDomainModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainIdentityServerModule))]
    public class IdentityDomainModule : AbpModule
{

}
