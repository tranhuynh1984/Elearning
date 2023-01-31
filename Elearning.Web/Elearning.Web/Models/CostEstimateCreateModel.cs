using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.CostEstimate;

namespace Elearning.Web.Models
{
    public class CostEstimateCreateModel
    {
        public string ViewMode { get; set; }
        public bool EnableCreate { get; set; }
        public bool EnableApprove { get; set; }

        public CostEstimateViewResponse DataView { get; set; }

        public string Record { get; set; }
        public int ReportForWeek { get; set; }
        public int RequestType { get; set; }
    }
}
