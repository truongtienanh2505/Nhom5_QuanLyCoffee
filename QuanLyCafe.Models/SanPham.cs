using System;


namespace QuanLyCafe.Models
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; } = string.Empty;
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime HanSuDung { get; set; }
    }
}
