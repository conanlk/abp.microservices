using Volo.Abp.Modularity;

namespace Wallet;

[DependsOn(
    typeof(WalletDomainModule),
    typeof(WalletTestBaseModule)
)]
public class WalletDomainTestModule : AbpModule
{

}
