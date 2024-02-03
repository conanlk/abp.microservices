using Volo.Abp.Modularity;

namespace Email;

[DependsOn(
    typeof(EmailApplicationModule),
    typeof(EmailDomainTestModule)
    )]
public class EmailApplicationTestModule : AbpModule
{

}
