namespace News;

public static class NewsDbProperties
{
    public static string DbTablePrefix { get; set; } = "News";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "News";
}
