namespace QuanLyCafe.UI
{
    partial class FrmDanhSachHoaDon
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
            panel2 = new Panel();
            panel3 = new Panel();
            dgvHoaDon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            label3 = new Label();
            dtpTo = new DateTimePicker();
            btnLoc = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            btnXemChiTiet = new Button();
            btnSearch = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 66);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnXemChiTiet);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLoc);
            panel2.Controls.Add(dtpTo);
            panel2.Controls.Add(dtpFrom);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 135);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvHoaDon);
            panel3.Location = new Point(5, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 255);
            panel3.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(4, 5);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(886, 245);
            dgvHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 8);
            label1.Name = "label1";
            label1.Size = new Size(505, 51);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 0;
            label2.Text = "Từ :";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(81, 14);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(300, 31);
            dtpFrom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 19);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 0;
            label3.Text = "Đến :";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(467, 14);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(300, 31);
            dtpTo.TabIndex = 2;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(777, 11);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(101, 34);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 77);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 4;
            label4.Text = "Tìm kiếm :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 31);
            txtSearch.TabIndex = 5;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new Point(720, 71);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(158, 34);
            btnXemChiTiet.TabIndex = 6;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(542, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 482);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDanhSachHoaDon";
            Text = "FrmDanhSachHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvHoaDon;
        private Button btnSearch;
        private Button btnXemChiTiet;
        private TextBox txtSearch;
        private Label label4;
        private Button btnLoc;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Label label3;
    }
}