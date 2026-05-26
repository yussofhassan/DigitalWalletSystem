namespace welllet.Forms
{
    partial class AddMoneyForm
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
            label1 = new Label();
            txtAmount = new TextBox();
            btnConfirm = new Button();
            btnExit = new Button();
            btnBack = new Button();
            panelTop.SuspendLayout();
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
            panelTop.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(597, 30);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(320, 185);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter Amount: ";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.Location = new Point(320, 220);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 39);
            txtAmount.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkBlue;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(320, 280);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(250, 60);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm Add";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(741, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 52);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Green;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 389);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 52);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddMoneyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 453);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(btnConfirm);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AddMoneyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Money";
            Load += AddMoneyForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblBalance;
        private Label lblWelcome;
        private Label label1;
        private TextBox txtAmount;
        private Button btnConfirm;
        private Button btnExit;
        private Button btnBack;
    }
}