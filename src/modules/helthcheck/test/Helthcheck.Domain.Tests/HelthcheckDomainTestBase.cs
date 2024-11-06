using Volo.Abp.Modularity;

namespace Helthcheck;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class HelthcheckDomainTestBase<TStartupModule> : HelthcheckTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
