namespace Sample.Auth.Interfaces;
public interface ISecretProvider
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
}