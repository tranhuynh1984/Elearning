using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.CashFollow;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.CashFollow;
using Elearning.Core.DTO.Response.CostEstimate;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.CashFollow
{
    public interface ICashFollowRepository
    {
        Task<IList<CashFollowGroup>> GetListCastFollowTypes(string subject);

        Task<CreateCashFollowResponse> CreateAsync(CashFollowCreateRequest request);

        Task<Database.Models.CashFollow> GetRawById(Guid g);
        Task<CashFollowExcelResponse> GetViewCashFollow(Guid g);
        Task<CashFollowResponse> SearchAsync(CashFollowSearchRequest request, int start, int length, string unitType);

        Task<CashFollowApproveResponse> Approval(CashFollowApproveRequest request, Database.Models.CashFollow record, SignatureCheckResponse sigCheck);

        Task<SignatureCheckResponse> CheckPermApproval(CashFollowApproveRequest request, Database.Models.CashFollow record);

        public Task<IList<CostEstimateLogResponse>> ViewHistories(CashFollowApproveRequest request);

        public Task<CompareCFAndActuallyResponse> ComparingAsync(CompareCFAndActuallyRequest request);

        Task<CashFollowApproveResponse> Delete(CashFollowApproveRequest request);

        Task<bool> AutoDecline(int financeYear, CashFollowApproveRequest declineModel, string positionAct);
    }
}
