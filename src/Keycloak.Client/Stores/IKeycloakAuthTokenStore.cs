using Keycloak.Client.Models;
using System;
using System.Threading.Tasks;

namespace Keycloak.Client.Stores
{
    public interface IKeycloakAuthTokenStore
    {
        Task<string> GetOrFetchAccessTokenAsync(Func<Task<TokenResponse>> fetchTokenFunc);
    }
}