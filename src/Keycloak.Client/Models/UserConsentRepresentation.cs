using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserConsentRepresentation
    {
        public string ClientId { get; set; }

        public long? CreatedDate { get; set; }

        public List<string> GrantedClientScopes { get; set; }

        public long? LastUpdatedDate { get; set; }
    }
}
