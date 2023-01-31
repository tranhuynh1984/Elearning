using System.Collections.Generic;
using Elearning.Core.Model;

namespace Elearning.Core.DTO.Request.CostEstimate
{
    public class CostEstimateUpdateRequest
    {
        public string record { get; set; }
        public List<LuckySheetCellModel> data { get; set; }
    }

    //public class CostEstimateUpdateRequestValidator : AbstractValidator<CostEstimateUpdateRequest>
    //{
    //    public CostEstimateUpdateRequestValidator()
    //    {
    //        RuleFor(m => m.record).NotEmpty();
    //        RuleFor(m => m.data).NotEmpty();

    //    }
    //}
}
