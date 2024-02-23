using Volo.Abp.Modularity;

namespace Email;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class EmailDomainTestBase<TStartupModule> : EmailTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
