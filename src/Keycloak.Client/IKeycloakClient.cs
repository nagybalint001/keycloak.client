using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Keycloak.Client.Models;

using Refit;

namespace Keycloak.Client
{
    public interface IKeycloakClient
    {
        [Get("/users")]
        Task<List<UserRepresentation>> GetUsersAsync(
            bool? briefRepresentation = null,
            string email = null,
            bool? emailVerified = null,
            bool? enabled = null,
            bool? exact = null,
            int? first = null,
            string firstName = null,
            string idpAlias = null,
            string idpUserId = null,
            string lastName = null,
            int? max = null,
            string search = null,
            string username = null);

        [Get("/users/{userId}")]
        Task<UserRepresentation> GetUserAsync(Guid userId);
    }
}
