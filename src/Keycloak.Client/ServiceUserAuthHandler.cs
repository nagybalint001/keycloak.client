using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Keycloak.Client.Models;

using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace Keycloak.Client
{
    public class ServiceUserAuthHandler : DelegatingHandler
    {
        private readonly IKeycloakAuthClient _keycloakAuthClient;
        private readonly IKeycloakAuthTokenStore _keycloakAuthTokenStore;
        private readonly IOptions<KeycloakOptions> _keycloakOptions;

        public ServiceUserAuthHandler(IKeycloakAuthClient keycloakAuthClient, IKeycloakAuthTokenStore keycloakAuthTokenStore, IOptions<KeycloakOptions> keycloakOptions)
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
                    ClientId = _keycloakOptions.Value?.ClientId,
                    ClientSecret = _keycloakOptions.Value?.ClientSecret,
                }));

                request.Headers.Add(HeaderNames.Authorization, $"Bearer {token}");
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
