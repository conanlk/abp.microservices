using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace News;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewsHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class NewsConsoleApiClientModule : AbpModule
{

}
