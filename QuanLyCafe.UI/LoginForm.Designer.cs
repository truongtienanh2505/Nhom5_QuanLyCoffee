namespace QuanLyCafe.UI
{
    partial class LoginForm
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
            panel3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
            panel2 = new Panel();
            txtUser = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(10, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 75);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 17);
            label1.Name = "label1";
            label1.Size = new Size(157, 55);
            label1.TabIndex = 0;
            label1.Text = "Coffee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 54);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 127);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(195, 124);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(279, 31);
            txtPass.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(8, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 192);
            panel2.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(195, 51);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(279, 31);
            txtUser.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(159, 16);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(386, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(605, 376);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPass;
        private Panel panel2;
        private TextBox txtUser;
    }
}