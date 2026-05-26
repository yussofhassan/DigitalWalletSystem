namespace welllet
{
    partial class LoginForm
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
            lblTitle = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(240, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Digital Wallet System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(220, 157);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 1;
            label1.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(399, 154);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 34);
            txtPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(271, 224);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(399, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(665, 228);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(314, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(314, 346);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(773, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 37);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.logo_wallet;
            pictureBox1.Image = Properties.Resources.logo_wallet;
            pictureBox1.Location = new Point(-34, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 453);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(220, 180);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Wallet Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}
