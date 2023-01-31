using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.CostEstimate;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.CostEstimate;
using Elearning.Core.DTO.Response.CostEstimateItem;
using Elearning.Core.DTO.Response.Notify;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.CostEstimate
{
    public interface ICostEstimateRepository
    {
        public Task<CostEstimateCreateResponse> Create(CostEstimateCreateRequest request);

        public Task<ApproveRequestOnCostEstimateResponse> Approve(CostEstimateApproveRequest request,
            Database.Models.CostEstimate record, SignatureCheckResponse sigCheck);

        public Task<CostEstimateViewResponse> LoadCostEstimateItemsData(CostEstimateViewRequest request);

        Task<Database.Models.CostEstimate> GetByIdAsync(Guid id);

        Task<IList<CostEstimateLogs>> GetCostEstimateLogs(Guid id);

        Task<SearchCostEstimateResponse> SearchAsync(SearchCostEstimateRequest request, int skip, int length, string unitType);
        Task<SearchCostEstimateResponse> SearchManage(SearchManageRequest request, int skip, int length);

        Task<SignatureCheckResponse> CheckPermissionApprove(CostEstimateCreateRequest request, Database.Models.CostEstimate record);

        Task<IList<NotifyData>> CheckUnitNotCreateYet();

        Task<IList<NotifyData>> CheckUnitNotApproveYet();

        /// <summary>
        /// Kiểm tra đơn vị đã tạo dự trù tuần
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="isSub"></param>
        /// <param name="weekReport"></param>
        /// <returns></returns>
        Task<bool> CanCreate(int unit, bool isSub, int weekReport);

        Task<bool> DeleteUnUsed();
    }
}
