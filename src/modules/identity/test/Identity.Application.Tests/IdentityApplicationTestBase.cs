using Volo.Abp.Modularity;

namespace Identity;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class IdentityApplicationTestBase<TStartupModule> : IdentityTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
