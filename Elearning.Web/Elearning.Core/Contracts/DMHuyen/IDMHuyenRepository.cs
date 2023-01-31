using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DMHuyen;
using Elearning.Core.DTO.Response.DMHuyen;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DMHuyen
{
    public interface IDMHuyenRepository
    {
        Task<DMHuyenSearchResponse> Search(int skip, int length, DMHuyenSearchRequest request);
        Task<DMHuyenSearchResponse> SearchAll(DMHuyenSearchRequest request);

    }
}
