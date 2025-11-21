using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private readonly HoaDonChiTietRepository _repo;

        public HoaDonChiTietService()
        {
            _repo = new HoaDonChiTietRepository();
        }

        public void ThemChiTiet(int maHd, int maSp, int soLuong)
        {
            _repo.ThemChiTiet(maHd, maSp, soLuong);
        }
        public void XoaChiTiet(int id)
        {
            _repo.XoaChiTiet(id);
        }

        public List<HoaDonChiTiet> GetByHoaDon(int maHd)
        {
            return _repo.GetByHoaDon(maHd);
        }
    }
}
