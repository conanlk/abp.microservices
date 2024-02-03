using Volo.Abp.Modularity;

namespace Identity;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class IdentityDomainTestBase<TStartupModule> : IdentityTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
