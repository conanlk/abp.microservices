using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Payment.EntityFrameworkCore;

public class PaymentHttpApiHostMigrationsDbContext : AbpDbContext<PaymentHttpApiHostMigrationsDbContext>
{
    public PaymentHttpApiHostMigrationsDbContext(DbContextOptions<PaymentHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigurePayment();
    }
}
