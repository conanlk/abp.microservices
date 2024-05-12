using Volo.Abp.Modularity;

namespace Order;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class OrderApplicationTestBase<TStartupModule> : OrderTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
