using Volo.Abp.Modularity;

namespace News;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class NewsApplicationTestBase<TStartupModule> : NewsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
