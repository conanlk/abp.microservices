using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Content;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ContentHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ContentConsoleApiClientModule : AbpModule
{

}
