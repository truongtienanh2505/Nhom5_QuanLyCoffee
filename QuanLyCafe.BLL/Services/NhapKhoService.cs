using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class NhapKhoService : INhapKhoService
    {
        private readonly NhapKhoRepository _nhapKhoRepository;

        public NhapKhoService()
        {
            _nhapKhoRepository = new NhapKhoRepository();
        }

        public void NhapKho(int maSp, int soLuong)
        {
            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            if (soLuong <= 0)
                throw new ArgumentException("Số lượng nhập phải > 0.");

            _nhapKhoRepository.NhapKho(maSp, soLuong);
        }

        public List<NhapKho> GetBySanPham(int maSp)
        {
            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            return _nhapKhoRepository.GetBySanPham(maSp);
        }
    }
}
