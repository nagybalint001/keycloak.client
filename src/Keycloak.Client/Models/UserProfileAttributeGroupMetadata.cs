using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserProfileAttributeGroupMetadata
    {
        public string Name { get; set; }

        public string DisplayHeader { get; set; }

        public string DisplayDescription { get; set; }

        public Dictionary<string, object> Annotations { get; set; }
    }
}
