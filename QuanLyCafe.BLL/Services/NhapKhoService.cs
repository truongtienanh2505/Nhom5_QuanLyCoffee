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
            ValidateNhapKho(maSp, soLuong);

            try
            {
                _nhapKhoRepository.NhapKho(maSp, soLuong);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi nhập kho: " + ex.Message, ex);
            }
        }

        public List<NhapKho> GetBySanPham(int maSp)
        {
            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");
            try
            {
                return _nhapKhoRepository.GetBySanPham(maSp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin nhập kho: " + ex.Message, ex);
            }
        }
        private void ValidateNhapKho(int maSp, int soLuong)
        {
            if (maSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            if (soLuong <= 0)
                throw new ArgumentException("Số lượng nhập phải lớn hơn 0.");
        }
    }
}
