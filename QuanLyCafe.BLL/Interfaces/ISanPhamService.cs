using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface ISanPhamService
    {
        List<SanPham> GetAll();
        void ThemSanPham(SanPham sp);
        void SuaSanPham(SanPham sp);
    }
}