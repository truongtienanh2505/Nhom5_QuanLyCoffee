using QuanLyCafe.BLL.Services;
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
    public partial class FrmSanPhamHetHan : Form
    {
        private readonly SanPhamService _service;

        public FrmSanPhamHetHan()
        {
            InitializeComponent();
            _service = new SanPhamService();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmSanPhamHetHan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvHetHan.DataSource = _service.GetSanPhamSapHetHan();
        }
    }
}
