namespace ShopLapTop.Shared.Models
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string MaCN { get; set; } // FK
        public string TenNV { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public string ChucVU { get; set; }
        public string Quyen { get; set; }
    }
}
