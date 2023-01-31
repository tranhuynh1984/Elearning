using System;
using System.ComponentModel.DataAnnotations;

namespace Elearning.Database.Models
{
    public class DMBangGiaChiNhanh
    {
        //Mã bảng giá chi nhánh
        [MaxLength(50)]
        [Required]
        public string MaBangGiaChiNhanh { get; set; }
        //Mã dịch vụ
        [MaxLength(50)]
        [Required]
        public string MaCP { get; set; }
        //Gia
        public float DG { get; set; }
    }
}
