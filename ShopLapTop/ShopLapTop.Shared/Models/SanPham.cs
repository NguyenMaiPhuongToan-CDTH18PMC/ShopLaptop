using System;

namespace ShopLapTop.Shared.Models
{
    class SanPham
    {
        public string MaSP { get; set; }
        public string MaNCC { get; set; } // FK
        public string MaNV { get; set; } //FK
        public int MaKM { get; set; } // FK
        public string TenSp { get; set; }
        public string LoaiSP { get; set; }
        public string ThuongHieu { get; set; }
        public string ChiTietSP { get; set; }
        public string MoTaSP { get; set; }
        public double DonGia { get; set; }
        public int DanhGia { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
    }
}
