using Volo.Abp.Modularity;

namespace Monitor;

[DependsOn(
    typeof(MonitorApplicationModule),
    typeof(MonitorDomainTestModule)
    )]
public class MonitorApplicationTestModule : AbpModule
{

}
