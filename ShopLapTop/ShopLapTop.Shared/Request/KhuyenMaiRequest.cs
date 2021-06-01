using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Request
{
    public class KhuyenMaiRequest
    {
        [StringLength(50)]
        public string TenKM { get; set; }
        public string MoTa { get; set; }
        public int LoaiKM { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
    }
}
