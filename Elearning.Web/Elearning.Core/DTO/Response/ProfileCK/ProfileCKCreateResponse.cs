﻿using Elearning.Core.DTO.Response.DM;
using System.Collections.Generic;

namespace Elearning.Core.DTO.Response.ProfileCK
{
    public class ProfileCKCreateResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<ItemError> ListError { get; set; }
        public ProfileCKSearchResponseData Data { get; set; }
    }
}
