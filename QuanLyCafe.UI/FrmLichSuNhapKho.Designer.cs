namespace QuanLyCafe.UI
{
    partial class FrmLichSuNhapKho
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
            label4 = new Label();
            btnLoc = new Button();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvLichSu = new DataGridView();
            cboSanPham = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 66);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 8);
            label1.Name = "label1";
            label1.Size = new Size(451, 51);
            label1.TabIndex = 0;
            label1.Text = "LỊCH SỬ NHẬP KHO";
            // 
            // panel2
            // 
            panel2.Controls.Add(cboSanPham);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLoc);
            panel2.Controls.Add(dtpTo);
            panel2.Controls.Add(dtpFrom);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 135);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 77);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 4;
            label4.Text = "Sản phẩm :";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(694, 64);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(120, 51);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(539, 13);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(300, 31);
            dtpTo.TabIndex = 2;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(108, 14);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(300, 31);
            dtpFrom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 18);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 0;
            label3.Text = "Đến ngày :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Từ ngày :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvLichSu);
            panel3.Location = new Point(22, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 255);
            panel3.TabIndex = 5;
            // 
            // dgvLichSu
            // 
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(4, 5);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 62;
            dgvLichSu.Size = new Size(886, 245);
            dgvLichSu.TabIndex = 0;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(130, 74);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(337, 33);
            cboSanPham.TabIndex = 5;
            // 
            // FrmLichSuNhapKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 502);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FrmLichSuNhapKho";
            Text = "FrmLichSuNhapKho";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnSearch;
        private Button btnXemChiTiet;
        private TextBox txtSearch;
        private Label label4;
        private Button btnLoc;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvLichSu;
        private ComboBox cboSanPham;
    }
}