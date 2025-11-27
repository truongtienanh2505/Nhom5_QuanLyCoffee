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
    public partial class FrmNhapKho : Form
    {
        private readonly NhapKhoService _nhapKhoService;
        public FrmNhapKho()
        {
            InitializeComponent();
            _nhapKhoService = new NhapKhoService();
            LoadSanPham();
            LoadNhapGanDay();
        }
        private void LoadSanPham()
        {
            // Giả sử bạn có danh sách sản phẩm từ DAL
            // Nếu chưa có, bạn cần tạo ProductService/GetAllProducts
            var sanPhamService = new QuanLyCafe.BLL.Services.SanPhamService();
            var listSP = sanPhamService.GetAll(); // List<SanPham>

            cboSanPham.DataSource = listSP;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.SelectedIndex = -1;
        }

        // Load lịch sử nhập kho gần đây vào DataGridView
        private void LoadNhapGanDay()
        {
            dgvNhapGanDay.Rows.Clear();

            if (cboSanPham.SelectedValue == null) return;

            int maSP = Convert.ToInt32(cboSanPham.SelectedValue);

            List<NhapKho> listNhap = _nhapKhoService.GetBySanPham(maSP);

            foreach (var nk in listNhap)
            {
                dgvNhapGanDay.Rows.Add(nk.MaNK, nk.MaSP, nk.SoLuong, nk.NgayNhap.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = Convert.ToInt32(cboSanPham.SelectedValue);
            int soLuong = (int)numSoLuong.Value;

            try
            {
                _nhapKhoService.NhapKho(maSP, soLuong);
                MessageBox.Show("Nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới DataGridView
                LoadNhapGanDay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhapGanDay();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {

        }
    }
}
