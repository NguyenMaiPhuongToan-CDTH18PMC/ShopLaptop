using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Request
{
    public class KhoRequest
    {
        [StringLength(50)]
        public string TenKho { get; set; }
        [StringLength(150)]
        [Required]
        public string DiaChi { get; set; }
        [StringLength(11)]
        [Phone]
        public string SDT { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
