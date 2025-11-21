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

        public HoaDonChiTietService()
        {
            _chiTietRepository = new HoaDonChiTietRepository();
        }

        public void ThemChiTiet(int maHd, int maSp, int soLuong)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            if (soLuong <= 0)
                throw new ArgumentException("Số lượng phải > 0.");

            _chiTietRepository.ThemChiTiet(maHd, maSp, soLuong);
        }

        public List<HoaDonChiTiet> GetByHoaDon(int maHd)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            return _chiTietRepository.GetByHoaDon(maHd);
        }
    }
}
