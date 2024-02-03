namespace Email;

public static class EmailDbProperties
{
    public static string DbTablePrefix { get; set; } = "Email";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Email";
}
