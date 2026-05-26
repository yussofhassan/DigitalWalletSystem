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
            btnExit = new Button();
            btnLogout = new Button();
            btnTransactions = new Button();
            btnSendMoney = new Button();
            btnAddMoney = new Button();
            panelTop.SuspendLayout();
            panelMenu.SuspendLayout();
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
            panelMenu.BackColor = Color.Gainsboro;
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnTransactions);
            panelMenu.Controls.Add(btnSendMoney);
            panelMenu.Controls.Add(btnAddMoney);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 100);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(882, 353);
            panelMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(718, 286);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 55);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(154, 149);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(260, 90);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Location = new Point(490, 149);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(260, 90);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnSendMoney
            // 
            btnSendMoney.Location = new Point(490, 21);
            btnSendMoney.Name = "btnSendMoney";
            btnSendMoney.Size = new Size(260, 90);
            btnSendMoney.TabIndex = 1;
            btnSendMoney.Text = "Send Money";
            btnSendMoney.UseVisualStyleBackColor = true;
            btnSendMoney.Click += btnSendMoney_Click;
            // 
            // btnAddMoney
            // 
            btnAddMoney.Location = new Point(154, 21);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(260, 90);
            btnAddMoney.TabIndex = 0;
            btnAddMoney.Text = "Add Money";
            btnAddMoney.UseVisualStyleBackColor = true;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 453);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMenu.ResumeLayout(false);
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
    }
}