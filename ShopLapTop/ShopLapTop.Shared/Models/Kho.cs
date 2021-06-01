using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Models
{
    public class Kho
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string MaKho { get; set; }
        [StringLength(50)]
        public string TenKho { get; set; }
        [StringLength(150)]
        public string DiaChi { get; set; }
        [StringLength(11)]
        [Phone]
        public string SDT { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [JsonIgnore]
        public virtual List<ChiNhanh> ChiNhanhs { get; set; }
    }
}
