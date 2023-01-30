using Keycloak.Client.Clients;
using System;
using Keycloak.Client.Options;
using Keycloak.Client.Stores;
using Microsoft.Extensions.DependencyInjection;
using RestEase.HttpClientFactory;

namespace Keycloak.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddKeycloakClient(this IServiceCollection services, Action<KeycloakOptions> configure)
        {
            var options = new KeycloakOptions();
            configure(options);
            services.AddSingleton(options);

            services.AddRestEaseClient<IKeycloakAuthClient>(
                $"{options.KeycloakBasePath}/realms/{(string.IsNullOrEmpty(options.AuthRealm) ? "master" : options.AuthRealm)}");

            services.AddTransient<KeycloakServiceUserAuthHandler>();
            services.AddSingleton<IKeycloakAuthTokenStore, KeycloakAuthTokenStore>();
            
            services.AddRestEaseClient<IKeycloakUserClient>($"{options.KeycloakBasePath}/admin/realms/{options.Realm}")
                .AddHttpMessageHandler<KeycloakServiceUserAuthHandler>();
        
            services.AddRestEaseClient<IKeycloakEventClient>($"{options.KeycloakBasePath}/admin/realms/{options.Realm}")
                .AddHttpMessageHandler<KeycloakServiceUserAuthHandler>();
            
            return services;
        }
    }
}
