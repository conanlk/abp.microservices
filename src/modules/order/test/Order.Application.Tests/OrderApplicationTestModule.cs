using Volo.Abp.Modularity;

namespace Order;

[DependsOn(
    typeof(OrderApplicationModule),
    typeof(OrderDomainTestModule)
    )]
public class OrderApplicationTestModule : AbpModule
{

}
