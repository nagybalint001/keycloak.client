using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Keycloak.Client.Extensions
{
    internal static class OptionsExtensions
    {
        /// <summary>
        /// Registers the given options class for later DI usage, and returns the current value to be used in Startup.ConfigureServices method
        /// </summary>
        /// <typeparam name="TOption">options class type</typeparam>
        /// <param name="services">Service collection</param>
        /// <param name="configuration">Configuration</param>
        /// <returns><typeparamref name="TOption"/> instance with the current values</returns>
        public static TOption ConfigureOption<TOption>(this IServiceCollection services, IConfiguration configuration)
            where TOption : class, new()
        {
            var options = new TOption();

            // for usage on the caller side
            configuration.GetSection(typeof(TOption).Name).Bind(options);

            // for IOption<TOption> based DI usage
            services.AddOptions<TOption>(typeof(TOption).Name);
            services.Configure<TOption>(configuration.GetSection(typeof(TOption).Name));

            return options;
        }
    }
}
