using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class CredentialRepresentation
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string UserLabel { get; set; }

        public long? CreatedDate { get; set; }

        public string SecretData { get; set; }

        public string CredentialData { get; set; }

        public int? Priority { get; set; }

        public string Value { get; set; }

        public bool? Temporary { get; set; }

        public string Device { get; set; }

        public string HashedSaltedValue { get; set; }

        public string Salt { get; set; }

        public int? HashIterations { get; set; }

        public int? Counter { get; set; }

        public string Algorithm { get; set; }

        public int? Digits { get; set; }

        public int? Period { get; set; }

        public Dictionary<string, List<string>> Config { get; set; }

        public string FederationLink { get; set; }
    }
}
