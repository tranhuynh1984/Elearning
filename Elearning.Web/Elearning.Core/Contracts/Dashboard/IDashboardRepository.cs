using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.Dashboard;
using Elearning.Core.DTO.Request.Notify;
using Elearning.Core.DTO.Response.Dashboard;

namespace Elearning.Core.Contracts.Dashboard
{
    public interface IDashboardRepository
    {
        Task<DashboardListResponse> SearchAsync(int offset, int limit, DashboardListRequest request);
        Task<DashboardExportResponse> Export(List<DashboardExportRequest> rq, List<FileNPlanType> excelPaths, List<FileNPlanType> pdfPaths, List<int> listUnitIds, string localPath);

        Task<bool> SendCreateNotify(string planType, int unitId, string forSubject, int year);
        Task<bool> SendOnApproval(SendFormat sendOnApproval);
    }
}
