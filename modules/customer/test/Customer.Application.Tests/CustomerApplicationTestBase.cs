using Volo.Abp.Modularity;

namespace Customer;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CustomerApplicationTestBase<TStartupModule> : CustomerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
