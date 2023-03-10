using System;
using System.Collections.Generic;
using System.Text;

namespace Elearning.Database.Models
{
    public class ActuallySpentLog
    {
        public Guid Id { get; set; }
        public Guid ActuallySpentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Creator { get; set; }
        public string CreatorName { get; set; }
        public string PositionName { get; set; }
        public int PositionId { get; set; }

        public int FromStatus { get; set; }
        public int ToStatus { get; set; }
        public string ToStatusName { get; set; }
        public string Reason { get; set; }
    }
}
