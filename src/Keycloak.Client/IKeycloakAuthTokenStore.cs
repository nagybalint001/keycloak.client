using System;
using System.Threading.Tasks;

using Keycloak.Client.Models;

namespace Keycloak.Client
{
    internal interface IKeycloakAuthTokenStore
    {
        Task<string> GetOrFetchAccessTokenAsync(Func<Task<TokenResponse>> fetchTokenFunc);
    }
}