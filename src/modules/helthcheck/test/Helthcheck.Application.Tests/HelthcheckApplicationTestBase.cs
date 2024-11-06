using Volo.Abp.Modularity;

namespace Helthcheck;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class HelthcheckApplicationTestBase<TStartupModule> : HelthcheckTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
