using Sample.Auth.Interfaces;

namespace Sample.Secrets;
public class LocalSecretProvider : ISecretProvider
{
    public string ClientId { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;

    public LocalSecretProvider()
    {
        Console.WriteLine("Created");
    }
}
