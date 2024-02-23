using Volo.Abp.Modularity;

namespace Monitor;

[DependsOn(
    typeof(MonitorDomainModule),
    typeof(MonitorTestBaseModule)
)]
public class MonitorDomainTestModule : AbpModule
{

}
