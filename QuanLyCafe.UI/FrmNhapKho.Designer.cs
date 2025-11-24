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
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 7);
            label1.Name = "label1";
            label1.Size = new Size(258, 51);
            label1.TabIndex = 0;
            label1.Text = "NHẬP KHO";
            // 
            // panel2
            // 
            panel2.Controls.Add(numSoLuong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboSanPham);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 50);
            panel2.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(501, 11);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(122, 31);
            numSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 13);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 2;
            label3.Text = "Số lượng :";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(118, 10);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(265, 33);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Sản Phẩm :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvNhapGanDay);
            panel3.Location = new Point(0, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(631, 189);
            panel3.TabIndex = 2;
            // 
            // dgvNhapGanDay
            // 
            dgvNhapGanDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapGanDay.Location = new Point(6, 4);
            dgvNhapGanDay.Name = "dgvNhapGanDay";
            dgvNhapGanDay.RowHeadersWidth = 62;
            dgvNhapGanDay.Size = new Size(622, 185);
            dgvNhapGanDay.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNhapKho);
            panel4.Location = new Point(1, 333);
            panel4.Name = "panel4";
            panel4.Size = new Size(631, 68);
            panel4.TabIndex = 3;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Location = new Point(417, 6);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(168, 50);
            btnNhapKho.TabIndex = 0;
            btnNhapKho.Text = "Nhập Kho";
            btnNhapKho.UseVisualStyleBackColor = true;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // FrmNhapKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 401);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmNhapKho";
            Text = "FrmNhapKho";
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
    }
}