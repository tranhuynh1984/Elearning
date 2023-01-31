using System;
using System.Collections.Generic;
using System.Text;
using Elearning.Core.DTO.Response.CostEstimateItem;
using Elearning.Core.Model;

namespace Elearning.Core.DTO.Request.CostEstimate
{
    public class CostEstimateRequest
    {
        public string record { get; set; }
        public List<LuckySheetCellModel> data { get; set; }
        public List<CostEstimateItemSearchResponseData> request { get; set; }
        public string type { get; set; }
        public int week { get; set; }
    }
}
