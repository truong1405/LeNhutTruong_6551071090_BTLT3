namespace Câu1
{
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
            lblNhapPassword = new Label();
            txtPassWord = new TextBox();
            lblHienThi1 = new Label();
            txtHienThi = new TextBox();
            btnHienThi = new Button();
            btnTiep = new Button();
            btnDong = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNhapPassword
            // 
            lblNhapPassword.AutoSize = true;
            lblNhapPassword.Location = new Point(104, 80);
            lblNhapPassword.Margin = new Padding(2, 0, 2, 0);
            lblNhapPassword.Name = "lblNhapPassword";
            lblNhapPassword.Size = new Size(113, 20);
            lblNhapPassword.TabIndex = 0;
            lblNhapPassword.Text = "Nhập Password:";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(259, 80);
            txtPassWord.Margin = new Padding(2, 2, 2, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(121, 27);
            txtPassWord.TabIndex = 1;
            txtPassWord.TextChanged += txtPassWord_TextChanged;
            // 
            // lblHienThi1
            // 
            lblHienThi1.AutoSize = true;
            lblHienThi1.Location = new Point(104, 131);
            lblHienThi1.Margin = new Padding(2, 0, 2, 0);
            lblHienThi1.Name = "lblHienThi1";
            lblHienThi1.Size = new Size(67, 20);
            lblHienThi1.TabIndex = 2;
            lblHienThi1.Text = "Hiển Thị:";
            lblHienThi1.Click += lblHienThi_Click;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(259, 126);
            txtHienThi.Margin = new Padding(2, 2, 2, 2);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(121, 27);
            txtHienThi.TabIndex = 3;
            txtHienThi.TextChanged += textBox1_TextChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(78, 281);
            btnHienThi.Margin = new Padding(2, 2, 2, 2);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(90, 27);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(278, 281);
            btnTiep.Margin = new Padding(2, 2, 2, 2);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(90, 27);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(499, 281);
            btnDong.Margin = new Padding(2, 2, 2, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(90, 27);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "6551071090";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(btnHienThi);
            Controls.Add(txtHienThi);
            Controls.Add(lblHienThi1);
            Controls.Add(txtPassWord);
            Controls.Add(lblNhapPassword);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapPassword;
        private TextBox txtPassWord;
        private Label lblHienThi1;
        private TextBox txtHienThi;
        private Button btnHienThi;
        private Button btnTiep;
        private Button btnDong;
        private Label label1;
    }
}
