using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abp.microservices.SaaSService.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
