namespace QuanLyCafe.UI
{
    partial class FrmThongKe
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
            groupBox1 = new GroupBox();
            dtpNgay = new DateTimePicker();
            label2 = new Label();
            btnThongKeNgay = new Button();
            btnThongKeThang = new Button();
            label3 = new Label();
            dtpThang = new DateTimePicker();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            lblSoHD = new Label();
            lblTBHoaDon = new Label();
            lblTongDoanhThu = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 6);
            label1.Name = "label1";
            label1.Size = new Size(540, 51);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(3, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 115);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThongKeNgay);
            groupBox1.Location = new Point(11, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê theo ngày";
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(150, 44);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(300, 31);
            dtpNgay.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn ngày :";
            // 
            // btnThongKeNgay
            // 
            btnThongKeNgay.Location = new Point(480, 44);
            btnThongKeNgay.Name = "btnThongKeNgay";
            btnThongKeNgay.Size = new Size(201, 34);
            btnThongKeNgay.TabIndex = 3;
            btnThongKeNgay.Text = "Thống kê theo ngày";
            btnThongKeNgay.UseVisualStyleBackColor = true;
            // 
            // btnThongKeThang
            // 
            btnThongKeThang.Location = new Point(479, 47);
            btnThongKeThang.Name = "btnThongKeThang";
            btnThongKeThang.Size = new Size(201, 34);
            btnThongKeThang.TabIndex = 4;
            btnThongKeThang.Text = "Thống kê theo tháng";
            btnThongKeThang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 2;
            label3.Text = "Chọn tháng :";
            // 
            // dtpThang
            // 
            dtpThang.Location = new Point(149, 47);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(300, 31);
            dtpThang.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(3, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 130);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpThang);
            groupBox2.Controls.Add(btnThongKeThang);
            groupBox2.Location = new Point(12, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 109);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê theo tháng";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Location = new Point(3, 335);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 149);
            panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSoHD);
            groupBox3.Controls.Add(lblTBHoaDon);
            groupBox3.Controls.Add(lblTongDoanhThu);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(685, 135);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // lblSoHD
            // 
            lblSoHD.AutoSize = true;
            lblSoHD.Location = new Point(537, 48);
            lblSoHD.Name = "lblSoHD";
            lblSoHD.Size = new Size(22, 25);
            lblSoHD.TabIndex = 8;
            lblSoHD.Text = "0";
            // 
            // lblTBHoaDon
            // 
            lblTBHoaDon.AutoSize = true;
            lblTBHoaDon.Location = new Point(206, 98);
            lblTBHoaDon.Name = "lblTBHoaDon";
            lblTBHoaDon.Size = new Size(22, 25);
            lblTBHoaDon.TabIndex = 7;
            lblTBHoaDon.Text = "0";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(206, 48);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(22, 25);
            lblTongDoanhThu.TabIndex = 6;
            lblTongDoanhThu.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(390, 48);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 5;
            label6.Text = "Số hoá đơn :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 98);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 4;
            label5.Text = "TB mỗi hoá đơn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 48);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 3;
            label4.Text = "Tổng doanh thu :";
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 499);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtpThang;
        private DateTimePicker dtpNgay;
        private Panel panel3;
        private Panel panel4;
        private Button btnThongKeThang;
        private Button btnThongKeNgay;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblSoHD;
        private Label lblTBHoaDon;
        private Label lblTongDoanhThu;
    }
}