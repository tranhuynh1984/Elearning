using System;
using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostStatus;
using Elearning.Core.Extensions;
using Elearning.Database.Models;

namespace Elearning.Core.DTO.Request.CostEstimate
{
    public class CostEstimateViewRequest
    {
        public string Record { get; set; }
        public Guid RawId => Guid.TryParse(Record.StringAesDecryption(PageRequest,true), out var g) ? g : Guid.Empty;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public IList<PositionModel> Positions { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public int Status { get; set; }
        public string PageRequest { get; set; }
    }
}
