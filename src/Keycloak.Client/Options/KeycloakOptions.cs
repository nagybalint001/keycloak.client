namespace Keycloak.Client.Models
{
    public class KeycloakOptions
    {
        public string KeycloakBasePath { get; set; }

        public string Realm { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
    }
}
