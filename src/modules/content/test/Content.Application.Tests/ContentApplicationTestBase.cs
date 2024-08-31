using Volo.Abp.Modularity;

namespace Content;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class ContentApplicationTestBase<TStartupModule> : ContentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
