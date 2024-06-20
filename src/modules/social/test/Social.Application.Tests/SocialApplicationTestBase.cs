using Volo.Abp.Modularity;

namespace Social;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class SocialApplicationTestBase<TStartupModule> : SocialTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
