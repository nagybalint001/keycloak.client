using System;

using Keycloak.Client.Models;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace Keycloak.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddKeycloakClient(this IServiceCollection services, IConfiguration configuration)
        {
            var options = services.ConfigureOption<KeycloakOptions>(configuration);

            services
                .AddRefitClient<IKeycloakAuthClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(options.KeycloakBasePath));

            services.AddTransient<ServiceUserAuthHandler>();
            services.AddSingleton<IKeycloakAuthTokenStore, KeycloakAuthTokenStore>();

            services
                .AddRefitClient<IKeycloakClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri($"{options.KeycloakBasePath}/auth/admin/realms/{options.Realm}"))
                .AddHttpMessageHandler<ServiceUserAuthHandler>();

            return services;
        }
    }
}
