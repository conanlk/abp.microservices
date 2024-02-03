namespace Customer;

public static class CustomerDbProperties
{
    public static string DbTablePrefix { get; set; } = "Customer";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Customer";
}
