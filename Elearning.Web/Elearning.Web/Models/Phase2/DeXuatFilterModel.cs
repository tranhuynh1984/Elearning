using System.Collections.Generic;
using Elearning.Core.DTO.Response.DeXuat;
using Elearning.Core.DTO.Response.DMCTV;
using Elearning.Core.DTO.Response.DMDV;
using Elearning.Core.DTO.Response.NhCP;
using Elearning.Core.DTO.Response.ProcessStep;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elearning.Web.Models.Dashboard
{
    public class DeXuatFilterModel
    {
        // Danh sách user
        public SelectList User { get; set; }

        // Danh sách loại đề xuất
        public SelectList LstLoaiDeXuat { get; set; }

        public SelectList LstUsers { get; set; }

        public int ChoDuyet { get; set; }
        public int DaDuyet { get; set; }
        public int HoanThanh { get; set; }
        public int QuaHan { get; set; }
        public string MaDonViDeXuat { get; set; }
    }

    public class DeXuatStepFilterModel
    {
        public DeXuatSearchResponseData DeXuatSearchResponseData { get; set; }

        public ProcessStepSearchResponse ProcessStepSearchResponseData { get; set; }

        public string DeXuatCode { get; set; }
        public int IDRole { get; set; }

        public string Title { get; set; }
    }
}