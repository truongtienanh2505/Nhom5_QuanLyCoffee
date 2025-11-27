using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QuanLyCafe.BLL.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly KhachHangRepository _repo;

        public KhachHangService()
        {
            _repo = new KhachHangRepository();
        }

        public List<KhachHang> GetAll()
        {
            return _repo.GetAll();
        }

        public KhachHang? GetById(int maKh)
        {
            return _repo.GetById(maKh);
        }

        public void ThemKhachHang(KhachHang kh)
        {
            ValidateKhachHang(kh);
            try
            {
                _repo.ThemKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm khách hàng: " + ex.Message);
            }
        }

        public void SuaKhachHang(KhachHang kh)
        {
            if (kh.MaKH <= 0)
                throw new Exception("Mã khách hàng không hợp lệ.");

            ValidateKhachHang(kh);
            try
            {
                _repo.SuaKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa khách hàng: " + ex.Message);
            }
        }

        public void XoaKhachHang(int maKh)
        {
            if (maKh <= 0)
                throw new Exception("Mã khách hàng không hợp lệ.");

            try
            {
                _repo.XoaKhachHang(maKh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xoá khách hàng: " + ex.Message);
            }
        }

        public List<KhachHang> TimKiem(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<KhachHang>(); // Không tìm gì nếu từ khóa rỗng

            try
            {
                return _repo.TimKiem(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm khách hàng: " + ex.Message, ex);
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
    