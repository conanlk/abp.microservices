using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Email;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmailHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class EmailConsoleApiClientModule : AbpModule
{

}
