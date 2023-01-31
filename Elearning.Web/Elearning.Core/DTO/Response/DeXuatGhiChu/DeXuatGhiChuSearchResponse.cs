using System;
using System.Collections.Generic;
using System.Text;
using Elearning.Core.DTO.Response.UpdateTime;

namespace Elearning.Core.DTO.Response.DeXuatGhiChu
{
    public class DeXuatGhiChuSearchResponseData
    {
        public string DeXuatCode { get; set; }
        public int ProcessStepId { get; set; }
        public string Note { get; set; }
        public string CreateByCode { get; set; }
        public string CreateByName { get; set; }
        public DateTime? CreateDate { get; set; }
    }

    public class DeXuatGhiChuSearchResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IList<DeXuatGhiChuSearchResponseData> Data { get; set; }
        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal { get; set; }
    }
}
