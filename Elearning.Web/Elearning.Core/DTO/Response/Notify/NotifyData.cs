using System;
using System.Collections.Generic;

namespace Elearning.Core.DTO.Response.Notify
{
    public class NotifyData
    {
        public List<string> Receiver { get; set; }
        public string Message { get; set; }
        public DateTime TimeCheck { get; set; }
    }
}
