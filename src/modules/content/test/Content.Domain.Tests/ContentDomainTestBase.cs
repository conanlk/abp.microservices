using Volo.Abp.Modularity;

namespace Content;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class ContentDomainTestBase<TStartupModule> : ContentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
