using QuanLyCafe.BLL.Services;
using QuanLyCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.UI
{
    public partial class FrmKhachHang : Form
    {
        private readonly KhachHangService _service = new KhachHangService();

        public FrmKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = _service.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang
            {
                TenKH = txtTenKH.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };
            _service.ThemKhachHang(kh);
            LoadData();
            MessageBox.Show("Thêm khách hàng thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaKH.Text, out int maKH))
            {
                var kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                };
                _service.SuaKhachHang(kh);
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaKH.Text, out int maKH))
            {
                _service.XoaKhachHang(maKH);
                LoadData();
                MessageBox.Show("Xóa khách hàng thành công!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtSearch.Clear();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();
            dgvKhachHang.DataSource = _service.TimKiem(key);
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
