using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostEstimateItem;

namespace Elearning.Core.DTO.Response.CostEstimate
{
    public class CostEstimateViewResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public List<CostEstimateItemSearchResponseData> Data { get; set; }

        public int ReportForWeek { get; set; }
        public int RequestType { get; set; }
        public Database.Models.CostEstimate CostEstimate { get; set; }
    }
}
