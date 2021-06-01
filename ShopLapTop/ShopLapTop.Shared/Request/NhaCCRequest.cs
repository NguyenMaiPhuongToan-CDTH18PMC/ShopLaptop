using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Request
{
    public class NhaCCRequest
    {
        [StringLength(50)]
        [Required]
        public string TenNCC { get; set; }
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
