namespace Keycloak.Client.Options
{
    public class KeycloakOptions
    {
        public string KeycloakBasePath { get; init; }

        public string AuthRealm { get; init; }

        public string Realm { get; init; }

        public string ClientId { get; init; }

        public string ClientSecret { get; init; }
    }
}
