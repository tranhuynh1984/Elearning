using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostStatus;

namespace Elearning.Web.Models
{
    public class CostEstimateItemListModel
    {
        public IEnumerable<StatusesGranted> Stats { get; set; }
        public string AccessToken { set; get; }

        public int DefaultStats { get; set; }
        public string DefaultStatsName { get; set; }

        public string RequestType { get; set; }
        public bool StatsFilterVisible { get; set; }
    }
}
