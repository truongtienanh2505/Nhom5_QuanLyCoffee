namespace QuanLyCafe.UI
{
    partial class FrmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvSanPham = new DataGridView();
            panel3 = new Panel();
            dtpHanSD = new DateTimePicker();
            txtSoLuongTon = new TextBox();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            btnSPSapHetHan = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 42);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSanPham);
            panel2.Location = new Point(3, 59);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 228);
            panel2.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(6, 2);
            dgvSanPham.Margin = new Padding(2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(382, 223);
            dgvSanPham.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpHanSD);
            panel3.Controls.Add(txtSoLuongTon);
            panel3.Controls.Add(txtDonGia);
            panel3.Controls.Add(txtTenSP);
            panel3.Controls.Add(txtMaSP);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(398, 59);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 228);
            panel3.TabIndex = 2;
            // 
            // dtpHanSD
            // 
            dtpHanSD.Location = new Point(81, 178);
            dtpHanSD.Margin = new Padding(2);
            dtpHanSD.Name = "dtpHanSD";
            dtpHanSD.Size = new Size(187, 27);
            dtpHanSD.TabIndex = 9;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(117, 143);
            txtSoLuongTon.Margin = new Padding(2);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(151, 27);
            txtSoLuongTon.TabIndex = 8;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(83, 104);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(185, 27);
            txtDonGia.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(73, 64);
            txtTenSP.Margin = new Padding(2);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(195, 27);
            txtTenSP.TabIndex = 6;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(73, 22);
            txtMaSP.Margin = new Padding(2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(195, 27);
            txtMaSP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 182);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 4;
            label6.Text = "Hạn SD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 3;
            label5.Text = "Số lượng tồn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 106);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 66);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên SP :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã SP :";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(3, 292);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(671, 51);
            panel4.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(490, 13);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(142, 14);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 27);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 17);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 0;
            label7.Text = "Tìm sản phẩm :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSPSapHetHan);
            panel5.Controls.Add(btnXoa);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(btnThem);
            panel5.Location = new Point(2, 348);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(673, 58);
            panel5.TabIndex = 4;
            // 
            // btnSPSapHetHan
            // 
            btnSPSapHetHan.Location = new Point(430, 13);
            btnSPSapHetHan.Margin = new Padding(2);
            btnSPSapHetHan.Name = "btnSPSapHetHan";
            btnSPSapHetHan.Size = new Size(208, 27);
            btnSPSapHetHan.TabIndex = 3;
            btnSPSapHetHan.Text = "Sản phẩm sắp hết/hết hạn";
            btnSPSapHetHan.UseVisualStyleBackColor = true;
            btnSPSapHetHan.Click += btnSPSapHetHan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(288, 13);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 27);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(146, 13);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 27);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(8, 13);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 27);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 406);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private DataGridView dgvSanPham;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtSoLuongTon;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private DateTimePicker dtpHanSD;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnSPSapHetHan;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}