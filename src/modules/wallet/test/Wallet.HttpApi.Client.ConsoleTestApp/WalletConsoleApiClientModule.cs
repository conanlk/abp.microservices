using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Wallet;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WalletHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class WalletConsoleApiClientModule : AbpModule
{

}
