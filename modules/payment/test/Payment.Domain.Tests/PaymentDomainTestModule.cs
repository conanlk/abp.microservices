using Volo.Abp.Modularity;

namespace Payment;

[DependsOn(
    typeof(PaymentDomainModule),
    typeof(PaymentTestBaseModule)
)]
public class PaymentDomainTestModule : AbpModule
{

}
