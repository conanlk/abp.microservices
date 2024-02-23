using Volo.Abp.Modularity;

namespace Payment;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class PaymentDomainTestBase<TStartupModule> : PaymentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
