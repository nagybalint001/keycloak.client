using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class UserProfileAttributeMetadata
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool? Required { get; set; }

        public bool? ReadOnly { get; set; }

        public Dictionary<string, object> Annotations { get; set; }

        public Dictionary<string, Dictionary<string, object>> Validators { get; set; }

        public string Group { get; set; }

        public bool? Multivalued { get; set; }

        public string DefaultValue { get; set; }
    }
}
