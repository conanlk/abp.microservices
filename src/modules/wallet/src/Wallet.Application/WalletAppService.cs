using Wallet.Localization;
using Volo.Abp.Application.Services;

namespace Wallet;

public abstract class WalletAppService : ApplicationService
{
    protected WalletAppService()
    {
        LocalizationResource = typeof(WalletResource);
        ObjectMapperContext = typeof(WalletApplicationModule);
    }
}
