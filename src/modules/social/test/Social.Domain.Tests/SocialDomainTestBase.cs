using Volo.Abp.Modularity;

namespace Social;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class SocialDomainTestBase<TStartupModule> : SocialTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
