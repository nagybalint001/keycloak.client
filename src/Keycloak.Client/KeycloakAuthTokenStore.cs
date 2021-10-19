using System;
using System.Threading.Tasks;

using Keycloak.Client.Models;

namespace Keycloak.Client
{
    public class KeycloakAuthTokenStore : IKeycloakAuthTokenStore
    {
        private DateTime _tokenExpiration = DateTime.MinValue;
        private Task<string> _lastFetchTask;

        public async Task<string> GetOrFetchAccessTokenAsync(Func<Task<TokenResponse>> fetchTokenFunc)
        {
            if (DateTime.UtcNow >= _tokenExpiration)
                _lastFetchTask = FetchToken(fetchTokenFunc);

            return await _lastFetchTask;
        }

        private async Task<string> FetchToken(Func<Task<TokenResponse>> fetchTokenFunc)
        {
            var tokenResponse = await fetchTokenFunc();
            _tokenExpiration = DateTime.UtcNow.AddSeconds(tokenResponse.ExpiresIn);

            return tokenResponse.AccessToken;
        }
    }
}
