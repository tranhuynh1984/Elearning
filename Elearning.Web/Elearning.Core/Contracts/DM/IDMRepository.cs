using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DM;
using Elearning.Core.DTO.Response.DM;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DM
{
    public interface IDMRepository
    {
        Task<DMSearchResponse> Search(int skip, int length, DMSearchRequest request);
        Task<DMSearchResponse> GetAllDM(int idTree);
        Task<DMSearchResponse> SearchAll(DMSearchRequest request);
        Task<DMSearchResponseData> GetById(int idTree, string maDM);
        Task<DMCreateResponse> Create(DMCreateRequest request);
        Task<DMCreateResponse> Remove(DMCreateRequest request);
        Task<int> GetMaxStt(int idTree);
    }
}
