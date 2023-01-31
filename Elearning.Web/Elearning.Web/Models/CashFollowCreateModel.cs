﻿using Elearning.Core.DTO.Response.CashFollow;

namespace Elearning.Web.Models
{
    public class CashFollowCreateModel
    {
        public CashFollowExcelResponse DataView { get; set; }
        public string Record { get; set; }
        public bool EnableCreate { get; set; }

        public bool IsError { get; set; }
        public string Message { get; set; }

        public int Status { get; set; }
    }
}
