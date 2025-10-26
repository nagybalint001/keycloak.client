using System.Collections.Generic;

namespace Keycloak.Client.Models
{
    public class EventRepresentation
    {
        public string Id { get; set; }

        public long Time { get; set; }

        public string Type { get; set; }

        public string RealmId { get; set; }

        public string ClientId { get; set; }

        public string UserId { get; set; }

        public string SessionId { get; set; }

        public string IpAddress { get; set; }

        public string Error { get; set; }

        public Dictionary<string, string> Details { get; set; }
    }
}
