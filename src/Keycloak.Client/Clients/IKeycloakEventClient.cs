using Keycloak.Client.Models;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Keycloak.Client.Clients
{
    public interface IKeycloakEventClient
    {
        [Get("/events")]
        Task<List<EventResponse>> GetEventsAsync(
        string client = null,
        string dateFrom = null,
        string dateTo = null,
        int? first = null,
        string ipAddress = null,
        int? max = null,
        [Query] IEnumerable<string> type = null,
        string user = null);
    }
}
