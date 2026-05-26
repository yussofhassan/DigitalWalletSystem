namespace welllet.Forms
{
    partial class DashboardForm
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
            panelTop = new Panel();
            lblBalance = new Label();
            lblWelcome = new Label();
            panelMenu = new Panel();
            btnChangePassword = new Button();
            btnExit = new Button();
            btnLogout = new Button();
            btnTransactions = new Button();
            btnSendMoney = new Button();
            btnAddMoney = new Button();
            pictureBox1 = new PictureBox();
            panelTop.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkBlue;
            panelTop.Controls.Add(lblBalance);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(882, 100);
            panelTop.TabIndex = 0;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(566, 33);
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnChangePassword);
            panelMenu.Controls.Add(btnTransactions);
            panelMenu.Controls.Add(btnSendMoney);
            panelMenu.Controls.Add(btnAddMoney);
            panelMenu.Location = new Point(0, 106);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(602, 233);
            panelMenu.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(42, 135);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(260, 90);
            btnChangePassword.TabIndex = 17;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(365, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 55);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Green;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(70, 355);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 55);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Location = new Point(324, 135);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(260, 90);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnSendMoney
            // 
            btnSendMoney.Location = new Point(324, 21);
            btnSendMoney.Name = "btnSendMoney";
            btnSendMoney.Size = new Size(260, 90);
            btnSendMoney.TabIndex = 1;
            btnSendMoney.Text = "Send Money";
            btnSendMoney.UseVisualStyleBackColor = true;
            btnSendMoney.Click += btnSendMoney_Click;
            // 
            // btnAddMoney
            // 
            btnAddMoney.Location = new Point(42, 21);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(260, 90);
            btnAddMoney.TabIndex = 0;
            btnAddMoney.Text = "Add Money";
            btnAddMoney.UseVisualStyleBackColor = true;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.logo_wallet;
            pictureBox1.Image = Properties.Resources.logo_wallet;
            pictureBox1.Location = new Point(577, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 453);
            Controls.Add(panelMenu);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);
            Controls.Add(panelTop);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblWelcome;
        private Label lblBalance;
        private Panel panelMenu;
        private Button btnAddMoney;
        private Button btnSendMoney;
        private Button btnTransactions;
        private Button btnLogout;
        private Button btnExit;
        private Button btnChangePassword;
        private PictureBox pictureBox1;
    }
}