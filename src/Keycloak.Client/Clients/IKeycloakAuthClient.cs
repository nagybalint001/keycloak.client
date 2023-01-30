using Keycloak.Client.Models;
using RestEase;
using System.Threading.Tasks;

namespace Keycloak.Client.Clients
{
    public interface IKeycloakAuthClient
    {
        [Post("/protocol/openid-connect/token")]
        Task<TokenResponse> GetServiceTokenAsync([Body(BodySerializationMethod.UrlEncoded)] ServiceClientCredentials credentials);
    }
}
