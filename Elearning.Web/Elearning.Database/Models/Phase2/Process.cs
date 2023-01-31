using System;
using System.Collections.Generic;
using System.Text;

namespace Elearning.Database.Models.Phase2
{
    public class Process : UpdateTime
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }

        public int ProcessRoleStart { get; set; }
    }
}