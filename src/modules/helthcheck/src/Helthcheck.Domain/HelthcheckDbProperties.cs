namespace Helthcheck;

public static class HelthcheckDbProperties
{
    public static string DbTablePrefix { get; set; } = "Helthcheck";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Helthcheck";
}
