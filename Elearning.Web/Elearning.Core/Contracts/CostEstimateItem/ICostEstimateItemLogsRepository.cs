using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.CostEstimateItem;
using Elearning.Core.DTO.Response.CostEstimateItem;

namespace Elearning.Core.Contracts.CostEstimateItem
{
    public interface ICostEstimateItemLogsRepository
    {
        public Task<IList<CostEstimateItemLogResponse>> ViewHistories(ViewHistoryRequest request);
    }
}
