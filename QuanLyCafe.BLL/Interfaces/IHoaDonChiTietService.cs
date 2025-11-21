using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface IHoaDonChiTietService
    {
        void ThemChiTiet(int maHd, int maSp, int soLuong);
        List<HoaDonChiTiet> GetByHoaDon(int maHd);
    }
}