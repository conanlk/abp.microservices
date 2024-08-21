using Volo.Abp.Modularity;

namespace Wallet;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class WalletDomainTestBase<TStartupModule> : WalletTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
