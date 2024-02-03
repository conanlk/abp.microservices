using Monitor.Localization;
using Volo.Abp.Application.Services;

namespace Monitor;

public abstract class MonitorAppService : ApplicationService
{
    protected MonitorAppService()
    {
        LocalizationResource = typeof(MonitorResource);
        ObjectMapperContext = typeof(MonitorApplicationModule);
    }
}
