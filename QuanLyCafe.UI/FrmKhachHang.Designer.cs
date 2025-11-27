namespace QuanLyCafe.UI
{
    partial class FrmKhachHang
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
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel5 = new Panel();
            btnSua = new Button();
            label7 = new Label();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            dgvKhachHang = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(537, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(190, 34);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(10, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLamMoi);
            panel5.Controls.Add(btnXoa);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(btnThem);
            panel5.Location = new Point(1, 436);
            panel5.Name = "panel5";
            panel5.Size = new Size(841, 72);
            panel5.TabIndex = 9;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(183, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 21);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 0;
            label7.Text = "Tìm khách hàng :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(91, 179);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(243, 31);
            txtDiaChi.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(91, 130);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(243, 31);
            txtSDT.TabIndex = 7;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(91, 80);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(243, 31);
            txtTenKH.TabIndex = 6;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(91, 27);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(243, 31);
            txtMaKH.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(613, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(191, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(401, 31);
            txtSearch.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(3, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 64);
            panel4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 182);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 133);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 2;
            label4.Text = "SDT :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên KH :";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDiaChi);
            panel3.Controls.Add(txtSDT);
            panel3.Controls.Add(txtTenKH);
            panel3.Controls.Add(txtMaKH);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(497, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 285);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã KH :";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(8, 3);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(477, 279);
            dgvKhachHang.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKhachHang);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 285);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 6);
            label1.Name = "label1";
            label1.Size = new Size(546, 51);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 66);
            panel1.TabIndex = 5;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 514);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel5;
        private Button btnSua;
        private Label label7;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private DataGridView dgvKhachHang;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
    }
}