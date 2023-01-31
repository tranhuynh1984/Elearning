using System;
using System.Collections.Generic;
using System.Text;
using Elearning.Core.DTO.Response.UpdateTime;

namespace Elearning.Core.DTO.Response.TBL_CTVGROUP
{
    public class TBL_CTVGROUPSearchResponseData : UpdateTimeResponseData
    {
        public int CTVGroupID { get; set; }
        public string CTVGroupName { get; set; }
    }

    public class TBL_CTVGROUPSearchResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IList<TBL_CTVGROUPSearchResponseData> Data { get; set; }
        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal { get; set; }
    }
}
