using Volo.Abp.Modularity;

namespace Email;

[DependsOn(
    typeof(EmailDomainModule),
    typeof(EmailTestBaseModule)
)]
public class EmailDomainTestModule : AbpModule
{

}
