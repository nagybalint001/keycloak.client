using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserProfileMetadata
    {
        public List<UserProfileAttributeMetadata> Attributes { get; set; }

        public List<UserProfileAttributeGroupMetadata> Groups { get; set; }
    }
}
