using Volo.Abp.Modularity;

namespace Order;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class OrderDomainTestBase<TStartupModule> : OrderTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
