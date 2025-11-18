namespace QuanLyCafe.UI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label1);
        panel1.Location = new Point(0, 1);
        panel1.Name = "panel1";
        panel1.Size = new Size(731, 71);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(287, 17);
        label1.Name = "label1";
        label1.Size = new Size(218, 37);
        label1.TabIndex = 0;
        label1.Text = "Trang đăng nhập";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(84, 155);
        label2.Name = "label2";
        label2.Size = new Size(85, 15);
        label2.TabIndex = 1;
        label2.Text = "Tên đăng nhập";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(84, 218);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 2;
        label3.Text = "Mật khẩu";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(198, 140);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(443, 43);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(198, 200);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(443, 43);
        textBox2.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new Point(198, 304);
        button1.Name = "button1";
        button1.Size = new Size(102, 23);
        button1.TabIndex = 5;
        button1.Text = "Xác nhận";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(361, 304);
        button2.Name = "button2";
        button2.Size = new Size(118, 23);
        button2.TabIndex = 6;
        button2.Text = "Quên mật khẩu";
        button2.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(733, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Trang đăng nhập";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
}
