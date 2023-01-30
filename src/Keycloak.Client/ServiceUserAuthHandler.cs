using Keycloak.Client.Clients;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Keycloak.Client.Models;
using Keycloak.Client.Options;
using Keycloak.Client.Stores;
using Microsoft.Net.Http.Headers;

namespace Keycloak.Client
{
    public class KeycloakServiceUserAuthHandler : DelegatingHandler
    {
        private readonly IKeycloakAuthClient _keycloakAuthClient;
        private readonly IKeycloakAuthTokenStore _keycloakAuthTokenStore;
        private readonly KeycloakOptions _keycloakOptions;

        public KeycloakServiceUserAuthHandler(IKeycloakAuthClient keycloakAuthClient, IKeycloakAuthTokenStore keycloakAuthTokenStore, KeycloakOptions keycloakOptions)
        {
            _keycloakAuthClient = keycloakAuthClient;
            _keycloakAuthTokenStore = keycloakAuthTokenStore;
            _keycloakOptions = keycloakOptions;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.Headers.Contains(HeaderNames.Authorization))
            {
                var token = await _keycloakAuthTokenStore.GetOrFetchAccessTokenAsync(() => _keycloakAuthClient.GetServiceTokenAsync(new ServiceClientCredentials()
                {
                    ClientId = _keycloakOptions.ClientId,
                    ClientSecret = _keycloakOptions.ClientSecret,
                }));

                request.Headers.Add(HeaderNames.Authorization, $"Bearer {token}");
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
