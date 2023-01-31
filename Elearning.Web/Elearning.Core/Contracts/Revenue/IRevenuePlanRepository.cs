using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.Data;
using Elearning.Core.DTO.Request.RevenuePlan;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.RevenuePlan;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Revenue
{
    public interface IRevenuePlanRepository
    {
        [EasyCachingAble(Expiration = CacheContant.EXPIRATION_30m, CacheKeyPrefix = CacheContant.PrefixRevenuePlanContents)]
        Task<IList<RevenuePlanContents>> ListRevenuePlanContents(string unitType);

        Task<RevenuePlanCreateResponse> Create(RevenuePlanCreateRequest request);
        Task<SearchRevenuePlanResponse> SearchAsync(SearchRevenuePlanRequest request, int offset, int limit, string unitType);
        //Task<RevenuePlanApproveResponse> Approval(RevenuePlanApproveRequest request);
        Task<RevenuePlanApproveResponse> Approval(RevenuePlanApproveRequest request, RevenuePlan record, SignatureCheckResponse sigCheck);

        Task<SignatureCheckResponse> CheckPermissionApprove(
            RevenuePlanApproveRequest request, RevenuePlan record);

        Task<RevenuePlan> GetByIdAsync(Guid id);
        Task<IList<RevenuePlanViewHistoryResponse>> ViewHistories(RevenuePlanViewHistoryRequest request);
        Task<RevenuePlanApproveResponse> Delete(RevenuePlanApproveRequest request);

        Task<IList<RevenuePlanCashDetails>> GetLatestUnitRevenuePlanCashDetails(int year, int unitId);
    }
}
