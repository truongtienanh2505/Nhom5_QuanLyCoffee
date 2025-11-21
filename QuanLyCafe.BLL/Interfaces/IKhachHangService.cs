using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface IKhachHangService
    {
        List<KhachHang> GetAll();
        KhachHang? GetById(int maKh);
        void ThemKhachHang(KhachHang kh);
        void SuaKhachHang(KhachHang kh);
        void XoaKhachHang(int maKh);
    }
}
