﻿using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostStatus;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elearning.Web.Models.Investment
{
    public class InvestmentListModel
    {
        public IEnumerable<StatusesGranted> Stats { get; set; }

        public List<SelectListItem> Units { get; set; }

        public int DefaultStats { get; set; }
        public string DefaultStatsName { get; set; }

        public bool EnableSearchUnit { get; set; }
    }
}