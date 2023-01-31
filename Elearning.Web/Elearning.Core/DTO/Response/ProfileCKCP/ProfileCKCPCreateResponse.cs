﻿using Elearning.Core.DTO.Response.DM;
using System.Collections.Generic;

namespace Elearning.Core.DTO.Response.ProfileCKCP
{
    public class ProfileCKCPCreateResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<ItemError> ListError { get; set; }
        public ProfileCKCPSearchResponseData Data { get; set; }
    }
}
