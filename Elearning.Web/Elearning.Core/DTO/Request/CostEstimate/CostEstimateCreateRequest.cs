using System.Collections.Generic;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.CostEstimateItem;
using Elearning.Core.DTO.Response.CostStatus;

namespace Elearning.Core.DTO.Request.CostEstimate
{
    public class CostEstimateCreateRequest
    {
        public string Record { get; set; }
        public string PageRequest { get; set; }
        public Database.Models.CostEstimate Primary { get; set; }
        public Database.Models.CostEstimate OlderPrimary { get; set; }

        public List<CostEstimateItemSearchResponseData> Data { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public bool PermissionEdit { get; set; }
        public string Type { get; set; }
        public bool IsApproval { get; set; }
        public string Reason { get; set; }

        public List<StatusesGranted> StatusAllowsSeen { get; set; }

        public SignatureCheckResponse CheckApprove { get; set; }
    }
}
