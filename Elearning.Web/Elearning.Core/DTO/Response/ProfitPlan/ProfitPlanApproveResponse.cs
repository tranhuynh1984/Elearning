using System;
using System.Collections.Generic;
using System.Text;

namespace Elearning.Core.DTO.Response.ProfitPlan
{
    public class ProfitPlanApproveResponse
    {
        public SearchProfitPlanResponseData Data { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
