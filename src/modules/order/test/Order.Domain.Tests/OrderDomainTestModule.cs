using Volo.Abp.Modularity;

namespace Order;

[DependsOn(
    typeof(OrderDomainModule),
    typeof(OrderTestBaseModule)
)]
public class OrderDomainTestModule : AbpModule
{

}
