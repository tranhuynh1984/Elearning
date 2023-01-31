using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.TBL_CTVGROUP;
using Elearning.Core.DTO.Response.TBL_CTVGROUP;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.TBL_CTVGROUP
{
    public interface ITBL_CTVGROUPRepository
    {
        Task<TBL_CTVGROUPSearchResponse> Search(int skip, int length, TBL_CTVGROUPSearchRequest request);
        Task<TBL_CTVGROUPSearchResponse> GetAllDM();
        Task<TBL_CTVGROUPSearchResponse> SearchAll(TBL_CTVGROUPSearchRequest request);
        Task<TBL_CTVGROUPSearchResponseData> GetById(int ctvGroupID);
    }
}
