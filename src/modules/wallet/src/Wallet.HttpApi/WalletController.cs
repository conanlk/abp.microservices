using Wallet.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Wallet;

public abstract class WalletController : AbpControllerBase
{
    protected WalletController()
    {
        LocalizationResource = typeof(WalletResource);
    }
}
