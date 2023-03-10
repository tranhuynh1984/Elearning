using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.TBL_CTVGROUPSUB2_DETAIL;
using Elearning.Core.DTO.Response.HDCTV;
using Elearning.Core.DTO.Response.TBL_CTVGROUPSUB2_DETAIL;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.TBL_CTVGROUPSUB2_DETAIL
{
    public interface ITBL_CTVGROUPSUB2_DETAILRepository
    {
        Task<TBL_CTVGROUPSUB2_DETAILSearchResponse> Search(int skip, int length, TBL_CTVGROUPSUB2_DETAILSearchRequest request);
        Task<TBL_CTVGROUPSUB2_DETAILSearchResponse> SearchAll(TBL_CTVGROUPSUB2_DETAILSearchRequest request);
        Task<TBL_CTVGROUPSUB2_DETAILSearchResponseData> GetById(int subid, string maCP);
        Task<TBL_CTVGROUPSUB2_DETAILCreateResponse> Create(TBL_CTVGROUPSUB2_DETAILCreateRequest request);
        Task<TBL_CTVGROUPSUB2_DETAILCreateResponse> Remove(TBL_CTVGROUPSUB2_DETAILCreateRequest request);
        Task<ImportToDBResponse> CreateRange(HdctvImportExcel<HdctvType2UploadResponse> request);
        Task<List<TBL_CTVGROUPSUB2_DETAILSearchResponseData>> GetAllBySubId(int subId);
    }
}
