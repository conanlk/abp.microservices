using Volo.Abp.Modularity;

namespace Helthcheck;

[DependsOn(
    typeof(HelthcheckDomainModule),
    typeof(HelthcheckTestBaseModule)
)]
public class HelthcheckDomainTestModule : AbpModule
{

}
