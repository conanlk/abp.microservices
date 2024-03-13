using Volo.Abp.Modularity;

namespace Product;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class ProductApplicationTestBase<TStartupModule> : ProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
