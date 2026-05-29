namespace welllet.Forms
{
    partial class ChangePasswordForm
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
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            panelTop = new Panel();
            lblBalance = new Label();
            lblWelcome = new Label();
            btnBack = new Button();
            btnExit = new Button();
            txtNewPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(70, 38);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 0;
            label1.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(263, 41);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(280, 27);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(190, 189);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 2;
            label2.Text = "New Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(242, 30);
            label3.TabIndex = 4;
            label3.Text = "Confirm New Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(263, 73);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DarkBlue;
            btnChangePassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(354, 303);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(280, 71);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkBlue;
            panelTop.Controls.Add(lblBalance);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(982, 100);
            panelTop.TabIndex = 7;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(583, 33);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(210, 38);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance: 0 EGP";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Green;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(354, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 52);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(505, 380);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 52);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(263, 106);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(280, 27);
            txtNewPassword.TabIndex = 23;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCurrentPassword);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(91, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 176);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.logo_wallet;
            pictureBox1.Image = Properties.Resources.logo_wallet;
            pictureBox1.Location = new Point(640, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 453);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(panelTop);
            Controls.Add(btnChangePassword);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += ChangePasswordForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCurrentPassword;
        private Label label2;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private Panel panelTop;
        private Label lblBalance;
        private Label lblWelcome;
        private Button btnBack;
        private Button btnExit;
        private TextBox txtNewPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}