using System;
using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class GroupRepresentation
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public Guid? ParentId { get; set; }

        public int? SubGroupCount { get; set; }

        public List<GroupRepresentation> SubGroups { get; set; }

        public Dictionary<string, List<string>> Attributes { get; set; }

        public List<string> RealmRoles { get; set; }

        public Dictionary<string, object> ClientRoles { get; set; }

        public Dictionary<string, bool> Access { get; set; }
    }
}
