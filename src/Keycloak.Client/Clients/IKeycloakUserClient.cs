using Keycloak.Client.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Keycloak.Client.Clients
{
    public interface IKeycloakUserClient
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

        [Get("/users")]
        Task<int> GetUsersCountAsync(
            string email = null,
            bool? emailVerified = null,
            string firstName = null,
            string lastName = null,
            string search = null,
            string username = null);

        [Get("/users/{userId}")]
        Task<UserRepresentation> GetUserAsync(Guid userId);

        [Post("/users")]
        Task CreateUserAsync([Body] UserRepresentation user);

        [Put("/users/{userId}")]
        Task UpdateUserAsync(Guid userId, [Body] UserRepresentation user);

        [Delete("/users/{userId}")]
        Task DeleteUserAsync(Guid userId);

        [Put("/users/{userId}/execute-actions-email")]
        Task ExecuteActionsAsync(
            Guid userId,
            [Body]List<string> actions,
            [Query] int? lifespan = null,
            [Query("redirect_uri")] string redirectUri = null,
            [Query("client_id")] string clientId = null);
    }
}
