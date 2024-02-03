using Volo.Abp.Modularity;

namespace Email;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class EmailApplicationTestBase<TStartupModule> : EmailTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
