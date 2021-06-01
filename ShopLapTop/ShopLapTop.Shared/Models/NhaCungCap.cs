using System.ComponentModel.DataAnnotations;

namespace ShopLapTop.Shared.Models
{
    public class NhaCungCap
    {
        [Required]
        [StringLength(50)]
        [Key]
        public string MaNCC { get; set; }
        [StringLength(50)]
        public string TenNCC { get; set; }
        [StringLength(150)]
        public string DiaChi { get; set; }
        [StringLength(11)]
        public string SDT { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
