using Volo.Abp.Modularity;

namespace Wallet;

[DependsOn(
    typeof(WalletApplicationModule),
    typeof(WalletDomainTestModule)
    )]
public class WalletApplicationTestModule : AbpModule
{

}
