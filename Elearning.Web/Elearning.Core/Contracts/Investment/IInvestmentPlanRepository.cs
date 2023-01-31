using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.Data;
using Elearning.Core.DTO.Request.InvestmentPlan;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.InvestmentPlan;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Investment
{
    public interface IInvestmentPlanRepository
    {
        [EasyCachingAble(Expiration = CacheContant.EXPIRATION_30m, CacheKeyPrefix = CacheContant.PrefixInvestmentPlanContents)]

        Task<IList<InvestmentPlanContents>> GetAllInvestmentPlanContentsForSubject(string subjectType);
        Task<InvestmentPlanCreateResponse> Create(InvestmentPlanCreateRequest request);
        Task<SearchInvestmentPlanResponse> SearchAsync(SearchInvestmentPlanRequest request, int offset, int limit, string unitType);
        Task<InvestmentPlanApproveResponse> Approval(InvestmentPlanApproveRequest request, InvestmentPlan record,SignatureCheckResponse sigCheck);
        Task<SignatureCheckResponse> CheckPermissionApprove(InvestmentPlanApproveRequest request, InvestmentPlan record);
        Task<InvestmentPlan> GetByIdAsync(Guid id);
        Task<InvestmentPlanApproveResponse> DeleteAsync(InvestmentPlanApproveRequest request);
        Task<IList<InvestmentPlanViewHistoryResponse>> ViewHistories(InvestmentPlanViewHistoryRequest request);
        Task<List<InvestmentPlanAggregate>> GetInvestmentPlanAggregateByYearAsync(int year, int unit);


    }
}
