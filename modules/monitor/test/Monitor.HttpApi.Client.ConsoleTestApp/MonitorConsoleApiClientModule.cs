using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Monitor;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MonitorHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class MonitorConsoleApiClientModule : AbpModule
{

}
