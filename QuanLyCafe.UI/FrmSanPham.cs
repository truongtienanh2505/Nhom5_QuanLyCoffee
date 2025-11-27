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
    public partial class FrmSanPham : Form
    {
        private readonly SanPhamService _service;
        public FrmSanPham()
        {
            InitializeComponent();
            this.dtpHanSD = new System.Windows.Forms.DateTimePicker();
            this.dtpHanSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanSD.TabIndex = 4;
            this.Controls.Add(this.dtpHanSD);
            _service = new SanPhamService();
            LoadData();
        }
        public void LoadData()
        {
            dgvSanPham.DataSource = _service.GetAll();
        }

        private void ClearFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
            dtpHanSD.Value = DateTime.Now;
        }

        private SanPham GetInput()
        {
            decimal donGia = 0;
            int soLuong = 0;
            decimal.TryParse(txtDonGia.Text, out donGia);
            int.TryParse(txtSoLuongTon.Text, out soLuong);
            int maSP = 0;
            int.TryParse(txtMaSP.Text, out maSP);

            return new SanPham
            {
                MaSP = maSP,
                TenSP = txtTenSP.Text,
                DonGia = donGia,
                SoLuongTon = soLuong,
                HanSuDung = dtpHanSD.Value
            };
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();
                if (DateTime.TryParse(row.Cells["HanSuDung"].Value.ToString(), out DateTime hanSD))
                {
                    dtpHanSD.Value = hanSD;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _service.ThemSanPham(GetInput());
                LoadData();
                ClearFields();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                _service.SuaSanPham(GetInput());
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSPSapHetHan_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = _service.GetSanPhamSapHetHan();
            FrmSanPhamHetHan frm = new FrmSanPhamHetHan();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào an toàn (Tránh crash do int.Parse)
            if (string.IsNullOrEmpty(txtMaSP.Text) || !int.TryParse(txtMaSP.Text, out int idCanXoa))
            {
                MessageBox.Show("Vui lòng nhập Mã sản phẩm hợp lệ (số nguyên)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hỏi xác nhận trước khi xóa (Quan trọng cho trải nghiệm người dùng)
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm có mã {idCanXoa} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            try
            {
                SanPham spAo = new SanPham { MaSP = idCanXoa };

                _service.XoaSanPham(spAo);

                // 4. Cập nhật lại giao diện
                LoadData();
                ClearFields();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE") || ex.InnerException?.Message.Contains("FK") == true)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì đã có trong hóa đơn hoặc phiếu nhập!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("not found") || ex.Message.Contains("không tìm thấy")) // Tùy vào cách Service bạn throw lỗi
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sp = new SanPham { TenSP = txtSearch.Text.Trim() };
            var results = _service.TimKiem(sp);
            dgvSanPham.DataSource = results;

            if (results.Count == 0)
                MessageBox.Show("Không tìm thấy sản phẩm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
