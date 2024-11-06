using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Helthcheck;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HelthcheckHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class HelthcheckConsoleApiClientModule : AbpModule
{

}
