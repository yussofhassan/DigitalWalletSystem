namespace welllet.Forms
{
    partial class SendMoneyForm
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
            btnBack = new Button();
            btnExit = new Button();
            btnSend = new Button();
            txtReceiver = new TextBox();
            label1 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
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
            // btnBack
            // 
            btnBack.BackColor = Color.Green;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 52);
            btnBack.TabIndex = 20;
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
            btnExit.Location = new Point(741, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 52);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DarkBlue;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(315, 280);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(250, 60);
            btnSend.TabIndex = 23;
            btnSend.Text = "Send Money";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtReceiver
            // 
            txtReceiver.Font = new Font("Segoe UI", 14F);
            txtReceiver.Location = new Point(149, 184);
            txtReceiver.MaxLength = 11;
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(250, 39);
            txtReceiver.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(149, 149);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 21;
            label1.Text = "Enter Receiver Phone:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.Location = new Point(493, 184);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 39);
            txtAmount.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(493, 149);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 24;
            label2.Text = "Enter Amount: ";
            // 
            // SendMoneyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 453);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(btnSend);
            Controls.Add(txtReceiver);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "SendMoneyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Send Money";
            Load += SendMoneyForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblBalance;
        private Label lblWelcome;
        private Button btnBack;
        private Button btnExit;
        private Button btnSend;
        private TextBox txtReceiver;
        private Label label1;
        private TextBox txtAmount;
        private Label label2;
    }
}