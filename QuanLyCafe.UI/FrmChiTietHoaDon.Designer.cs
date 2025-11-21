namespace QuanLyCafe.UI
{
    partial class FrmChiTietHoaDon
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
            panel4 = new Panel();
            lblMaHD = new Label();
            label2 = new Label();
            btnIn = new Button();
            btnXoaDong = new Button();
            txtMaHoaDon = new TextBox();
            dgvCTHD = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 77);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMaHoaDon);
            panel2.Controls.Add(lblMaHD);
            panel2.Location = new Point(2, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 54);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCTHD);
            panel3.Location = new Point(1, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 215);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnXoaDong);
            panel4.Controls.Add(btnIn);
            panel4.Location = new Point(2, 368);
            panel4.Name = "panel4";
            panel4.Size = new Size(795, 81);
            panel4.TabIndex = 3;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaHD.Location = new Point(27, 13);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(130, 23);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã Hoá Đơn :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 15);
            label2.Name = "label2";
            label2.Size = new Size(436, 51);
            label2.TabIndex = 0;
            label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // btnIn
            // 
            btnIn.Location = new Point(429, 15);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(128, 55);
            btnIn.TabIndex = 0;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(618, 15);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(128, 55);
            btnXoaDong.TabIndex = 0;
            btnXoaDong.Text = "Xoá Dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(173, 8);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(315, 31);
            txtMaHoaDon.TabIndex = 1;
            // 
            // dgvCTHD
            // 
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Location = new Point(5, 5);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.RowHeadersWidth = 62;
            dgvCTHD.Size = new Size(788, 207);
            dgvCTHD.TabIndex = 0;
            // 
            // FrmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmChiTietHoaDon";
            Text = "FrmChiTietHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label lblMaHD;
        private Panel panel3;
        private Panel panel4;
        private Button btnXoaDong;
        private Button btnIn;
        private TextBox txtMaHoaDon;
        private DataGridView dgvCTHD;
    }
}