namespace Keycloak.Client.Models
{
    public class CredentialRepresentation
    {
        public long? CreatedDate { get; set; }

        public string CredentialData { get; set; }

        public string Id { get; set; }

        public int? Priority { get; set; }

        public string SecretData { get; set; }

        public bool? Temporary { get; set; }

        public string Type { get; set; }

        public string UserLabel { get; set; }

        public string Value { get; set; }
    }
}
