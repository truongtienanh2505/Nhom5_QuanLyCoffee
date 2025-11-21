namespace QuanLyCafe.UI
{
    partial class MainForm
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
            btnThongKe = new Button();
            btnNhapKho = new Button();
            btnBanHang = new Button();
            btnKhachHang = new Button();
            btnSanPham = new Button();
            panel4 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblTotalSP = new Label();
            lblSPHetHan = new Label();
            lblDoanhThu = new Label();
            lblSoHD = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnNhapKho);
            panel1.Controls.Add(btnBanHang);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 442);
            panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(0, 284);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(306, 49);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Location = new Point(1, 229);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(305, 49);
            btnNhapKho.TabIndex = 2;
            btnNhapKho.Text = "Nhập Kho";
            btnNhapKho.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            btnBanHang.Location = new Point(1, 174);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(305, 49);
            btnBanHang.TabIndex = 2;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(0, 119);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(306, 49);
            btnKhachHang.TabIndex = 2;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            btnSanPham.Location = new Point(0, 63);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(306, 49);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 255, 128);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 53);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 35);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 56);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 7);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 0;
            label1.Text = "Trang chủ Allied Coffee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSoHD);
            panel3.Controls.Add(lblDoanhThu);
            panel3.Controls.Add(lblSPHetHan);
            panel3.Controls.Add(lblTotalSP);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(313, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 442);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 241);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 4;
            label7.Text = "Hóa đơn hôm nay :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 186);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 3;
            label6.Text = "Doanh thu hôm nay :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 2;
            label5.Text = "SP sắp hết hạn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 1;
            label4.Text = "Tổng sản phẩm :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 255, 128);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 57);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(167, 13);
            label3.Name = "label3";
            label3.Size = new Size(147, 35);
            label3.TabIndex = 1;
            label3.Text = "Thông Tin";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSP
            // 
            lblTotalSP.AutoSize = true;
            lblTotalSP.Location = new Point(164, 75);
            lblTotalSP.Name = "lblTotalSP";
            lblTotalSP.Size = new Size(59, 25);
            lblTotalSP.TabIndex = 5;
            lblTotalSP.Text = "label8";
            // 
            // lblSPHetHan
            // 
            lblSPHetHan.AutoSize = true;
            lblSPHetHan.Location = new Point(164, 131);
            lblSPHetHan.Name = "lblSPHetHan";
            lblSPHetHan.Size = new Size(59, 25);
            lblSPHetHan.TabIndex = 6;
            lblSPHetHan.Text = "label9";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Location = new Point(206, 186);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(69, 25);
            lblDoanhThu.TabIndex = 7;
            lblDoanhThu.Text = "label10";
            // 
            // lblSoHD
            // 
            lblSoHD.AutoSize = true;
            lblSoHD.Location = new Point(192, 241);
            lblSoHD.Name = "lblSoHD";
            lblSoHD.Size = new Size(69, 25);
            lblSoHD.TabIndex = 8;
            lblSoHD.Text = "label11";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 507);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btnThongKe;
        private Button btnNhapKho;
        private Button btnBanHang;
        private Button btnKhachHang;
        private Button btnSanPham;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Label label7;
        private Label lblSoHD;
        private Label lblDoanhThu;
        private Label lblSPHetHan;
        private Label lblTotalSP;
    }
}