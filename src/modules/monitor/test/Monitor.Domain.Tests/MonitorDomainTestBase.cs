using Volo.Abp.Modularity;

namespace Monitor;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class MonitorDomainTestBase<TStartupModule> : MonitorTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
