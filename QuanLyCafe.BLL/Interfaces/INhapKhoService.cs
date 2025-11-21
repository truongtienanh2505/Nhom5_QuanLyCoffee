using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface INhapKhoService
    {
        void NhapKho(int maSp, int soLuong);
        List<NhapKho> GetBySanPham(int maSp);
    }
}