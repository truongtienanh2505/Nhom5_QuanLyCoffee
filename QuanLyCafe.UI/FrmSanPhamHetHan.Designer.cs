namespace QuanLyCafe.UI
{
    partial class FrmSanPhamHetHan
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
            label1 = new Label();
            dgvHetHan = new DataGridView();
            btnLamMoi = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHetHan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 66);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHetHan);
            panel2.Location = new Point(3, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 288);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLamMoi);
            panel3.Location = new Point(3, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 82);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(638, 41);
            label1.TabIndex = 0;
            label1.Text = "SẢN PHẨM SẮP HẾT HẠN/ HẾT HẠN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHetHan
            // 
            dgvHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHetHan.Location = new Point(5, 5);
            dgvHetHan.Name = "dgvHetHan";
            dgvHetHan.RowHeadersWidth = 62;
            dgvHetHan.Size = new Size(712, 280);
            dgvHetHan.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(507, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(126, 50);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // FrmSanPhamHetHan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 451);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmSanPhamHetHan";
            Text = "FrmSanPhamHetHan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHetHan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvHetHan;
        private Button btnLamMoi;
    }
}