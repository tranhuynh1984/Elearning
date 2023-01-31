using System;
using System.Collections.Generic;
using System.Text;
using Elearning.Core.Extensions;

namespace Elearning.Core.DTO.Request.Actually
{
    public class ActuallyLogRequest
    {
        public string Record { get; set; }
        public string RequestPage { get; set; }
        public Guid RawId => Guid.TryParse(Record.StringAesDecryption(RequestPage, true), out var i) ? i : Guid.Empty;
    }
}
