using Volo.Abp.Modularity;

namespace Monitor;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class MonitorApplicationTestBase<TStartupModule> : MonitorTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
