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
            try
            {
                _khachHangRepository.ThemKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm khách hàng: " + ex.Message);
            }
        }

        public void SuaKhachHang(KhachHang kh)
        {
            if (kh == null)
                throw new ArgumentNullException(nameof(kh));

            if (kh.MaKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            ValidateKhachHang(kh);
            try
            {
                _khachHangRepository.SuaKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa khách hàng: " + ex.Message);
            }
        }

        public void XoaKhachHang(int maKh)
        {
            if (maKh <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            try
            {
                _khachHangRepository.XoaKhachHang(maKh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xoá khách hàng: " + ex.Message);
            }
        }

        private void ValidateKhachHang(KhachHang kh)
        {
            if (kh == null)
                throw new ArgumentNullException(nameof(kh));

            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống.");

            if (!string.IsNullOrWhiteSpace(kh.SDT))
            {
                if (!Regex.IsMatch(kh.SDT, @"^(0[0-9]{9})$"))
                    throw new ArgumentException("Số điện thoại không hợp lệ (phải 10 số).");
            }
        }
    }
}
