namespace Notification;

public static class NotificationDbProperties
{
    public static string DbTablePrefix { get; set; } = "Notification";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Notification";
}
