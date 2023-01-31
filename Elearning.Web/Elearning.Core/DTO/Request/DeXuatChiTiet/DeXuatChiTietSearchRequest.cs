﻿namespace Elearning.Core.DTO.Request.DeXuatChiTiet
{
    public class DeXuatChiTietSearchRequest
    {
        public int Status { get; set; }
        public int Draw { get; set; }
        public string DeXuatCode { get; set; }
        public string FieldName { get; set; }
        public string ValueOld { get; set; }
        public string ValueNew { get; set; }
        public string Note { get; set; }
        public int ProcessId { get; set; }
        public int ProcessStepId { get; set; }
    }
}
