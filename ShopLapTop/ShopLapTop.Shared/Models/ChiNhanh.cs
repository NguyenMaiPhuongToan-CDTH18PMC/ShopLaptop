using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopLapTop.Shared.Models
{
    public class ChiNhanh
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string MaCN { get; set; }
        [StringLength(50)]
        public string KhoMaKho { get; set; } //FK   
        [JsonIgnore]
        public virtual Kho Kho { get; set; }
        [StringLength(50)]
        public string TenCN { get; set; }
        [StringLength(150)]
        public string DiaChi { get; set; }
        [StringLength(11)]
        public string SDT { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
