namespace WinFormsApp1
{
    partial class fLogin
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
            btnThoat = new Button();
            btnDangNhap = new Button();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            bxtUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 220);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(468, 162);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(302, 162);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(108, 29);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 65);
            panel3.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(156, 22);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(444, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(bxtUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 65);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // bxtUsername
            // 
            bxtUsername.Location = new Point(156, 22);
            bxtUsername.Name = "bxtUsername";
            bxtUsername.Size = new Size(444, 27);
            bxtUsername.TabIndex = 1;
            bxtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 243);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox bxtUsername;
        private Label label1;
        private Button btnThoat;
        private Button btnDangNhap;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label2;
    }
}
