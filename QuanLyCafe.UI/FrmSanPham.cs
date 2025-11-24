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
            return new SanPham
            {
                MaSP = string.IsNullOrEmpty(txtMaSP.Text) ? 0 : int.Parse(txtMaSP.Text),
                TenSP = txtTenSP.Text,
                DonGia = decimal.Parse(txtDonGia.Text),
                SoLuongTon = int.Parse(txtSoLuongTon.Text),
                HanSuDung = dtpHanSD.Value
            };
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtSoLuongTon.Text = dgvSanPham.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
                dtpHanSD.Value = Convert.ToDateTime(
                    dgvSanPham.Rows[e.RowIndex].Cells["HanSuDung"].Value);
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
    }
}
