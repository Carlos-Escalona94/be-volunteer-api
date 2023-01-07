using Sample.Auth.Interfaces;

namespace Sample.Secrets;
public class LocalSecretProvider : ISecretProvider
{
    public string ClientId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string ClientSecret { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
