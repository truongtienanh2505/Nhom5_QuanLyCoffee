using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly KhachHangRepository _khachHangRepository;

        public KhachHangService()
        {
            _khachHangRepository = new KhachHangRepository();
        }

        public List<KhachHang> GetAll()
        {
            return _khachHangRepository.GetAll();
        }

        public KhachHang? GetById(int maKh)
        {
            if (maKh <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            return _khachHangRepository.GetById(maKh);
        }

        public void ThemKhachHang(KhachHang kh)
        {
            ValidateKhachHang(kh);
            _khachHangRepository.ThemKhachHang(kh);
        }

        public void SuaKhachHang(KhachHang kh)
        {
            if (kh == null)
                throw new ArgumentNullException(nameof(kh));

            if (kh.MaKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            ValidateKhachHang(kh);
            _khachHangRepository.SuaKhachHang(kh);
        }

        public void XoaKhachHang(int maKh)
        {
            if (maKh <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            _khachHangRepository.XoaKhachHang(maKh);
        }

        private void ValidateKhachHang(KhachHang kh)
        {
            if (kh == null)
                throw new ArgumentNullException(nameof(kh));

            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống.");

            
        }
    }
}
