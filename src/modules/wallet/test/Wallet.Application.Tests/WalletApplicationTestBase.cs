using Volo.Abp.Modularity;

namespace Wallet;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class WalletApplicationTestBase<TStartupModule> : WalletTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
