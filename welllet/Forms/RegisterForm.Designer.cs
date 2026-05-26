namespace welllet.Forms
{
    partial class RegisterForm
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
            lblTitle = new Label();
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            cmbGender = new ComboBox();
            label6 = new Label();
            dtBirthDate = new DateTimePicker();
            btnCreate = new Button();
            btnBack = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(220, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create New Wallet";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(108, 125);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(220, 125);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(344, 34);
            txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(108, 196);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(285, 196);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 34);
            txtPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(108, 253);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(285, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(108, 314);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(285, 314);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 34);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(642, 165);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(642, 196);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 28);
            cmbGender.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(642, 268);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 11;
            label6.Text = "Birth Date";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(642, 299);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(200, 27);
            dtBirthDate.TabIndex = 12;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkBlue;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(336, 390);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(250, 45);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(336, 455);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(250, 35);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back To Login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(773, 504);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 37);
            btnExit.TabIndex = 15;
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
            pictureBox1.Location = new Point(29, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(dtBirthDate);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Label label5;
        private ComboBox cmbGender;
        private Label label6;
        private DateTimePicker dtBirthDate;
        private Button btnCreate;
        private Button btnBack;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}