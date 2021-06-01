using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Request
{
    public class ChiNhanhRequest
    {
        [StringLength(50)]
        public string MaKho { get; set; }
        [StringLength(50)]
        [Required]
        public string TenCN { get; set; }
        [StringLength(150)]
        [Required]
        public string DiaChi { get; set; }
        [StringLength(11)]
        public string SDT { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
