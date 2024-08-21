namespace Wallet;

public static class WalletDbProperties
{
    public static string DbTablePrefix { get; set; } = "Wallet";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Wallet";
}
