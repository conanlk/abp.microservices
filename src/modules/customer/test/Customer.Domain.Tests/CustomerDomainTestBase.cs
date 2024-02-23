using Volo.Abp.Modularity;

namespace Customer;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CustomerDomainTestBase<TStartupModule> : CustomerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
