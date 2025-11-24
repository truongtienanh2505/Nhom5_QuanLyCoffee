using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface IBanService
    {
        List<Ban GetAll();
        Ban? GetById(int maBan);
        void CapNhatTrangThai(int maBan, int trangThai);
    }
}
}
