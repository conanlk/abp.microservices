using Volo.Abp.Modularity;

namespace Product;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class ProductDomainTestBase<TStartupModule> : ProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
