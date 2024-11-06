using Volo.Abp.Modularity;

namespace Helthcheck;

[DependsOn(
    typeof(HelthcheckApplicationModule),
    typeof(HelthcheckDomainTestModule)
    )]
public class HelthcheckApplicationTestModule : AbpModule
{

}
