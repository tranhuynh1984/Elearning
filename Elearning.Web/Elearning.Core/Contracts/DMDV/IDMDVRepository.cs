using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DMDV;
using Elearning.Core.DTO.Response.DMDV;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DMDV
{
    public interface IDMDVRepository
    {
        Task<DMDVSearchResponse> Search(int skip, int length, DMDVSearchRequest request);

        Task<DMDVSearchResponse> SearchAll(DMDVSearchRequest request);

        Task<List<DMDVSearchResponseData>> GetCategory();
    }
}