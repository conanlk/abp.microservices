using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Payment.EntityFrameworkCore;

public class PaymentServiceMigrationsDbContext : AbpDbContext<PaymentServiceMigrationsDbContext>
{
    public PaymentServiceMigrationsDbContext(DbContextOptions<PaymentServiceMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigurePayment();
    }
}
