using System;
using System.Collections.Generic;
using System.Text;
using Elearning.Core.Extensions;

namespace Elearning.Core.DTO.Request.RevenuePlan
{
    public class RevenuePlanViewHistoryRequest
    {
        public string Record { get; set; }
        public string PageRequest { get; set; }

        //giải mã ID
        public Guid RawId => Guid.TryParse(Record.StringAesDecryption(PageRequest, true), out var g) ? g : Guid.Empty;
    }
}
