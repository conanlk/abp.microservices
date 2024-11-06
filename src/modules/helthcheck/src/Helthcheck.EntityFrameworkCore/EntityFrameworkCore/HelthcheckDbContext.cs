using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Helthcheck.EntityFrameworkCore;

[ConnectionStringName(HelthcheckDbProperties.ConnectionStringName)]
public class HelthcheckDbContext : AbpDbContext<HelthcheckDbContext>, IHelthcheckDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public HelthcheckDbContext(DbContextOptions<HelthcheckDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureHelthcheck();
        builder.ConfigureTenantManagement();
        }
}
