using System;
using System.ComponentModel.DataAnnotations;

namespace ShopLapTop.Shared.Models
{
    public class KhuyenMai
    {
        [Required]
        [Key]
        public int MaKM { get; set; }
        [StringLength(50)]
        public string TenKM { get; set; }
        public string MoTa { get; set; }
        public int LoaiKM { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
    }
}
