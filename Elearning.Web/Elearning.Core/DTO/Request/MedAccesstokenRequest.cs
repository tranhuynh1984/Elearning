using System;
using System.Collections.Generic;
using System.Text;

namespace Elearning.Core.DTO.Request
{
    public class MedAccesstokenRequest
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string scope { get; set; }
        public string client_secret { get; set; }

    }
}
