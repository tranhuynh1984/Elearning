using System;
using Elearning.Core.Extensions;

namespace Elearning.Core.DTO.Request.Actually
{
    public class GetActuallySpentByIdRequest
    {
        public string Record { get; set; }
        public Guid RawId => Guid.TryParse(Record.StringAesDecryption(PageRequest,true), out var g) ? g : Guid.Empty;
        public string PageRequest { get; set; }
        public int UnitId { get; set; }
    }
}
