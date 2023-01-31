using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.Relationship;
using Elearning.Core.DTO.Response.Relationship;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Relationship
{
    public interface IRelationshipRepository
    {
        Task<RelationshipSearchResponse> Search(int skip, int length, RelationshipSearchRequest request);
        Task<RelationshipSearchResponse> GetAllRelationShip();
        Task<RelationshipSearchResponse> SearchAll(RelationshipSearchRequest request);
        Task<RelationshipSearchResponseData> GetById(string RelationshipCode);
        Task<RelationshipCreateResponse> Create(RelationshipCreateRequest request);
        Task<RelationshipCreateResponse> Remove(RelationshipCreateRequest request);
        Task<int> GetMaxStt();

    }
}
