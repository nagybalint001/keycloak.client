using System.Threading.Tasks;

using Keycloak.Client.Models;

using Refit;

namespace Keycloak.Client
{
    public interface IKeycloakAuthClient
    {
        [Post("/auth/realms/master/protocol/openid-connect/token")]
        Task<TokenResponse> GetServiceTokenAsync([Body(BodySerializationMethod.UrlEncoded)] ServiceClientCredentials credentials);
    }
}
