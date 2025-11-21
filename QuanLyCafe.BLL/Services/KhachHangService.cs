using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;
using System;
using System.Collections.Generic;

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
            if (string.IsNullOrEmpty(kh.TenKH) || string.IsNullOrEmpty(kh.SDT))
                throw new Exception("Tên và SDT không được để trống.");

            _repo.ThemKhachHang(kh);
        }

        public void SuaKhachHang(KhachHang kh)
        {
            if (kh.MaKH <= 0)
                throw new Exception("Mã khách hàng không hợp lệ.");

            _repo.SuaKhachHang(kh);
        }

        public void XoaKhachHang(int maKh)
        {
            if (maKh <= 0)
                throw new Exception("Mã khách hàng không hợp lệ.");

            _repo.XoaKhachHang(maKh);
        }

        public List<KhachHang> TimKiem(string keyword)
        {
            return _repo.TimKiem(keyword);
        }
    }
}
    