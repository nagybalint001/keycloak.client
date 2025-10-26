using System;
using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserRepresentation
    {
        public Guid? Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool? EmailVerified { get; set; }

        public Dictionary<string, List<string>> Attributes { get; set; }

        public UserProfileMetadata UserProfileMetadata { get; set; }

        public bool? Enabled { get; set; }

        public string Self { get; set; }

        public string Origin { get; set; }

        public long? CreatedTimestamp { get; set; }

        public bool? Totp { get; set; }

        public string FederationLink { get; set; }

        public string ServiceAccountClientId { get; set; }

        public List<CredentialRepresentation> Credentials { get; set; }

        public List<string> DisableableCredentialTypes { get; set; }

        public List<string> RequiredActions { get; set; }

        public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }

        public List<string> RealmRoles { get; set; }

        public Dictionary<string, object> ClientRoles { get; set; }

        public List<UserConsentRepresentation> ClientConsents { get; set; }

        public int? NotBefore { get; set; }

        public Dictionary<string, List<string>> ApplicationRoles { get; set; }

        public List<SocialLinkRepresentation> SocialLinks { get; set; }
        
        public List<string> Groups { get; set; }

        public Dictionary<string, bool> Access { get; set; }
    }
}
