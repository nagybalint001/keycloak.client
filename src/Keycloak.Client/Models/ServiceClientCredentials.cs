using System.Text.Json.Serialization;

namespace Keycloak.Client.Models
{
    public class ServiceClientCredentials
    {
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "client_credentials";
    }
}
