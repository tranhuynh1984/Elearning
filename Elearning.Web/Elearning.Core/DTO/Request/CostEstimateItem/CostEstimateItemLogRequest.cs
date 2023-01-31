using Elearning.Core.Extensions;

namespace Elearning.Core.DTO.Request.CostEstimateItem
{
    public class ViewHistoryRequest
    {
        public string CostEstimateId { get; set; }
        public string PageRequest { get; set; }

        public string CostEstimateRawId => CostEstimateId.StringAesDecryption(PageRequest);
    }
}
