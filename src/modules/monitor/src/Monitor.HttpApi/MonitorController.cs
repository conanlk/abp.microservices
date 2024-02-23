using Monitor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Monitor;

public abstract class MonitorController : AbpControllerBase
{
    protected MonitorController()
    {
        LocalizationResource = typeof(MonitorResource);
    }
}
