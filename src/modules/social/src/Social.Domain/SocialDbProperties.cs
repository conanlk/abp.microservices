namespace Social;

public static class SocialDbProperties
{
    public static string DbTablePrefix { get; set; } = "Social";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Social";
}
