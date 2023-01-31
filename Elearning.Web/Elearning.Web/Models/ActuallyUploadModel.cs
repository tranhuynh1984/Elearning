using System.Collections.Generic;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.Actually;

namespace Elearning.Web.Models
{
    public class ActuallyUploadModel
    {
        public List<ActuallySpentItemResponse> Data  { get; set; }
        public float TotalCost { get; set; }
        public float TotalActualSpent { get; set; }
        public float TotalAmountLeft { get; set; }
        public float TotalActualSpentAtTime { get; set; }
    }
}
