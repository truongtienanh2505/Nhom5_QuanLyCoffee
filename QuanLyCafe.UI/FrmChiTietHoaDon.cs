using QuanLyCafe.BLL.Interfaces;
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
    public partial class FrmChiTietHoaDon : Form
    {
        private readonly IHoaDonService _hdService;
        private readonly IHoaDonChiTietService _ctService;
        private int _maHD;

        public FrmChiTietHoaDon(int maHD, IHoaDonService hdService, IHoaDonChiTietService ctService)
        {
            InitializeComponent();

            _hdService = hdService;
            _ctService = ctService;
            _maHD = maHD;
        }

        private void LoadChiTietHoaDon()
        {
            dgvCTHD.DataSource = _ctService.GetByHoaDon(_maHD);
            var hd = _hdService.GetById(_maHD);
            if (hd != null)
            {
                lblMaHD.Text = $"Mã HĐ: {_maHD}";
            }
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = _maHD.ToString();
            LoadChiTietHoaDon();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
                return;
            }

            int idCT = (int)dgvCTHD.SelectedRows[0].Cells["ID"].Value;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _ctService.XoaChiTiet(idCT);
                _hdService.TinhTienHoaDon(_maHD);

                LoadChiTietHoaDon();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in chưa được triển khai");
        }
    }
}
