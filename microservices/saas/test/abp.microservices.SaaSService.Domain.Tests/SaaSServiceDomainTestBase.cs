using Volo.Abp.Modularity;

namespace abp.microservices.SaaSService;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class SaaSServiceDomainTestBase<TStartupModule> : SaaSServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
