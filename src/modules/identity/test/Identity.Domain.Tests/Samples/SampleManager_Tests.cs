using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace Identity.Samples;

public abstract class SampleManager_Tests<TStartupModule> : IdentityDomainTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
