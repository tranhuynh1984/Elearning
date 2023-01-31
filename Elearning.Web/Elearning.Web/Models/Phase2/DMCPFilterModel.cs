using System.Collections.Generic;

using Elearning.Core.DTO.Response.DMDV;
using Elearning.Core.DTO.Response.NhCP;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elearning.Web.Models.Dashboard
{
    public class DMCPFilterModel
    {
        // Danh sách đơn vị có bảng giá riêng
        public SelectList Branchs { get; set; }

        // Danh sách nhóm dịch vụ
        public SelectList Categories { get; set; }
    }
}