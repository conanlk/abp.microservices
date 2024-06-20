using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Social;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SocialHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SocialConsoleApiClientModule : AbpModule
{

}
