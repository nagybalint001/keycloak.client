using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Keycloak.Client.Models;

using Refit;

namespace Keycloak.Client
{
    public interface IKeycloakGroupClient
    {
        [Get("/groups")]
        Task<List<GroupRepresentation>> GetGroupsAsync(
            bool? briefRepresentation = null,
            bool? exact = null,
            int? first = null,
            int? max = null,
            bool? populateHierarchy = null,
            string q = null,
            string search = null,
            bool? subGroupsCount = null);

        [Get("/groups/count")]
        Task<int> GetGroupsCountAsync(
            string search = null,
            bool? top = null);

        [Get("/groups/{groupId}")]
        Task<GroupRepresentation> GetGroupAsync(Guid groupId);

        [Get("/groups/{groupId}/children")]
        Task<List<GroupRepresentation>> GetGroupChildrenAsync(
            Guid groupId,
            bool? briefRepresentation = null,
            bool? exact = null,
            int? first = null,
            int? max = null,
            string search = null,
            bool? subGroupsCount = null);

        [Post("/groups/{groupId}/children")]
        Task CreateGroupChildrenAsync(Guid groupId, [Body] GroupRepresentation group);

        [Delete("/groups/{groupId}")]
        Task DeleteGroupAsync(Guid groupId);

        [Post("/groups")]
        Task CreateGroupAsync([Body] GroupRepresentation group);

        [Put("/groups/{groupId}")]
        Task UpdateGroupAsync(Guid groupId, [Body] GroupRepresentation group);
    }
}
