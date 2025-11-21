using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly SanPhamRepository _repo;

        public SanPhamService()
        {
            _repo = new SanPhamRepository();
        }

        public List<SanPham> GetAll()
        {
            return _repo.GetAll();
        }

        public void ThemSanPham(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new Exception("Tên sản phẩm không được để trống!");

            if (sp.DonGia <= 0)
                throw new Exception("Đơn giá phải lớn hơn 0!");

            _repo.ThemSanPham(sp);
        }

        public void SuaSanPham(SanPham sp)
        {
            if (sp.MaSP <= 0)
                throw new Exception("Mã sản phẩm không hợp lệ!");

            _repo.SuaSanPham(sp);
        }
        public void XoaSanPham(int maSP)
        {
            _repo.XoaSanPham(maSP);
        }

        public List<SanPham> TimKiem(string keyword)
        {
            return _repo.TimKiem(keyword);
        }

        public List<SanPham> GetSanPhamSapHetHan()
        {
            return _repo.GetSanPhamSapHetHan();
        }
    }
}
