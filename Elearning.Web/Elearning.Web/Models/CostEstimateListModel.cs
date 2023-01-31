using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostStatus;
using Elearning.Database.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elearning.Web.Models
{
    public class CostEstimateListModel
    {
        public IEnumerable<StatusesGranted> Stats { get; set; }
        public List<SelectListItem> Units { get; set; }

        public int DefaultStats { get; set; }
        public string DefaultStatsName { get; set; }

        public string RequestType { get; set; }
        public bool EnableSearchUnit { get; set; }
    }
}
