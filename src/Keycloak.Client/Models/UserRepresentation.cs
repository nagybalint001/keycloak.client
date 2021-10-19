using System;
using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserRepresentation
    {
        public Dictionary<string, bool> Access { get; set; }

        public Dictionary<string, List<string>> Attributes { get; set; }

        public List<UserConsentRepresentation> ClientConsents { get; set; }

        public Dictionary<string, object> ClientRoles { get; set; }

        public long? CreatedTimestamp { get; set; }

        public List<CredentialRepresentation> Credentials { get; set; }

        public List<string> DisableableCredentialTypes { get; set; }

        public string Email { get; set; }

        public bool? EmailVerified { get; set; }

        public bool? Enabled { get; set; }

        public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }

        public string FederationLink { get; set; }

        public string FirstName { get; set; }

        public List<string> Groups { get; set; }

        public Guid? Id { get; set; }

        public string LastName { get; set; }

        public int? NotBefore { get; set; }

        public string Origin { get; set; }

        public List<string> RealmRoles { get; set; }

        public string Self { get; set; }

        public string ServiceAccountClientId { get; set; }

        public bool? Totp { get; set; }

        public string Username { get; set; }
    }
}
