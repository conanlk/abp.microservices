namespace Content;

public static class ContentDbProperties
{
    public static string DbTablePrefix { get; set; } = "Content";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Content";
}
