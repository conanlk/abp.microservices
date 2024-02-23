using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Customer;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CustomerConsoleApiClientModule : AbpModule
{

}
