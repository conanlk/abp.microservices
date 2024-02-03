namespace Monitor;

public static class MonitorDbProperties
{
    public static string DbTablePrefix { get; set; } = "Monitor";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Monitor";
}
