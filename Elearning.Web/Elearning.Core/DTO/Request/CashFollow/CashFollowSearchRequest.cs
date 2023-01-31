using System.Collections.Generic;
using Elearning.Core.DTO.Response.CostStatus;
using Elearning.Database.Models;

namespace Elearning.Core.DTO.Request.CashFollow
{
    public class CashFollowSearchRequest
    {
        public int Year { get; set; }
        public int Status { get; set; }

        public int Draw { get; set; }

        // Mã ID của đơn vị
        // Đơn vị nào chỉ nhìn thấy thực chi của đơn vị đó
        public int UserUnit { get; set; }

        // Key của page
        // Dùng để mã hóa ID
        public string PageRequest { get; set; }

        public string HostFileView { get; set; }

        public bool IsSub { get; set; }

        public bool PermissionEdit { get; set; }
        public bool PermissionApprove { get; set; }
        public bool PermissionDelete { get; set; }
        public IEnumerable<StatusesGranted> StatusAllowsSeen { get; set; }
        public IList<UserUnitsManages> UserUnitsManages { get; set; }

    }
}
