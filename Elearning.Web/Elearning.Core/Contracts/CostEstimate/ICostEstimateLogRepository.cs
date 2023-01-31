using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.CostEstimate;
using Elearning.Core.DTO.Response.CostEstimate;

namespace Elearning.Core.Contracts.CostEstimate
{
    public interface ICostEstimateLogRepository
    {
        public Task<IList<CostEstimateLogResponse>> ViewHistories(CostEstimateLogRequest request);

    }
}
