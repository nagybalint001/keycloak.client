using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Keycloak.Client.Models;

using Refit;

namespace Keycloak.Client
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
            string q = null,
            string search = null,
            string username = null);

        [Get("/users/count")]
        Task<int> GetUsersCountAsync(
            string email = null,
            bool? emailVerified = null,
            bool? enabled = null,
            bool? exact = null,
            string firstName = null,
            string idpAlias = null,
            string idpUserId = null,
            string lastName = null,
            string q = null,
            string search = null,
            string username = null);

        [Get("/users/{userId}")]
        Task<UserRepresentation> GetUserAsync(Guid userId, bool? userProfileMetadata);

        [Post("/users")]
        Task CreateUserAsync([Body] UserRepresentation user);

        [Put("/users/{userId}")]
        Task UpdateUserAsync(Guid userId, [Body] UserRepresentation user);

        [Delete("/users/{userId}")]
        Task DeleteUserAsync(Guid userId);

        [Put("/users/{userId}/execute-actions-email")]
        Task ExecuteActionsAsync(
            Guid userId,
            [Body] List<string> actions,
            [Query][AliasAs("client_id")] string clientId = null,
            [Query] int? lifespan = null,
            [Query][AliasAs("redirect_uri")] string redirectUri = null);
    }
}
