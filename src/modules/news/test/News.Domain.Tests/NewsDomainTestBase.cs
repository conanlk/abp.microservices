using Volo.Abp.Modularity;

namespace News;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class NewsDomainTestBase<TStartupModule> : NewsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
