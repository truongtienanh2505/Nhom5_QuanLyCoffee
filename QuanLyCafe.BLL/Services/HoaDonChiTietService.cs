using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private readonly HoaDonChiTietRepository _chiTietRepository;
        private readonly HoaDonRepository _hoaDonRepository;
        private readonly SanPhamRepository _sanPhamRepository;


        public HoaDonChiTietService()
        {
            _chiTietRepository = new HoaDonChiTietRepository();
            _hoaDonRepository = new HoaDonRepository();
            _sanPhamRepository = new SanPhamRepository();
        }

        public void ThemChiTiet(int maHd, int maSp, int soLuong)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            if (soLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0.");

            var hoaDon = _hoaDonRepository.GetById(maHd);
            if (hoaDon == null)
                throw new Exception("Không tìm thấy hóa đơn.");

            var sanPham = _sanPhamRepository.GetById(maSp);
            if (sanPham == null)
                throw new Exception("Không tìm thấy sản phẩm.");

            if (sanPham.SoLuongTon < soLuong)
                throw new Exception("Số lượng tồn không đủ để bán.");

            var ct = new HoaDonChiTiet
            {
                MaHd = maHd,
                MaSp = maSp,
                SoLuong = soLuong,
                DonGia = sanPham.DonGia
            };
            _chiTietRepository.ThemChiTiet(maHd, maSp, soLuong);
        }

        public List<HoaDonChiTiet> GetByHoaDon(int maHd)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");
            var result = _chiTietRepository.GetByHoaDon(maHd);
            return result ?? new List<HoaDonChiTiet>();
        }
    }
}
