using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Keycloak.Client.Models
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
        [Query(CollectionFormat.Multi)] IEnumerable<string> type = null,
        string user = null);
    }
}
