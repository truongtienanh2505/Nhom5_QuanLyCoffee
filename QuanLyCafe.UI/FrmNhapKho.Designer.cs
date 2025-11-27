namespace QuanLyCafe.UI
{
    partial class FrmNhapKho
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
            numSoLuong = new NumericUpDown();
            label3 = new Label();
            cboSanPham = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            dgvNhapGanDay = new DataGridView();
            MaNK = new DataGridViewTextBoxColumn();
            MaSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnNhapKho = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapGanDay).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 42);
            label1.TabIndex = 0;
            label1.Text = "NHẬP KHO";
            // 
            // panel2
            // 
            panel2.Controls.Add(numSoLuong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboSanPham);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 64);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 40);
            panel2.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(401, 9);
            numSoLuong.Margin = new Padding(2);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(98, 27);
            numSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng :";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(94, 8);
            cboSanPham.Margin = new Padding(2);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(213, 28);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 0;
            label2.Text = "Sản Phẩm :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvNhapGanDay);
            panel3.Location = new Point(0, 109);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 151);
            panel3.TabIndex = 2;
            // 
            // dgvNhapGanDay
            // 
            dgvNhapGanDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapGanDay.Columns.AddRange(new DataGridViewColumn[] { MaNK, MaSP, SoLuong, NgayNhap });
            dgvNhapGanDay.Location = new Point(5, 3);
            dgvNhapGanDay.Margin = new Padding(2);
            dgvNhapGanDay.Name = "dgvNhapGanDay";
            dgvNhapGanDay.RowHeadersWidth = 62;
            dgvNhapGanDay.Size = new Size(498, 148);
            dgvNhapGanDay.TabIndex = 0;
            // 
            // MaNK
            // 
            MaNK.HeaderText = "Mã nhập kho";
            MaNK.MinimumWidth = 6;
            MaNK.Name = "MaNK";
            MaNK.Width = 125;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // NgayNhap
            // 
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.Width = 125;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNhapKho);
            panel4.Location = new Point(1, 266);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(505, 54);
            panel4.TabIndex = 3;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Location = new Point(334, 5);
            btnNhapKho.Margin = new Padding(2);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(134, 40);
            btnNhapKho.TabIndex = 0;
            btnNhapKho.Text = "Nhập Kho";
            btnNhapKho.UseVisualStyleBackColor = true;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // FrmNhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 321);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FrmNhapKho";
            Text = "FrmNhapKho";
            Load += FrmNhapKho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhapGanDay).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private NumericUpDown numSoLuong;
        private Label label3;
        private ComboBox cboSanPham;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvNhapGanDay;
        private Panel panel4;
        private Button btnNhapKho;
        private DataGridViewTextBoxColumn MaNK;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn NgayNhap;
    }
}