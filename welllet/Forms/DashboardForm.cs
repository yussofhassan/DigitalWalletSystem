using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using welllet.Classes;

namespace welllet.Forms
{
    public partial class DashboardForm : Form
    {

        public string UserName;
        public decimal Balance;
        public int UserID;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserName;

            lblBalance.Text = "Balance: " + Balance + " EGP";
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            AddMoneyForm addForm = new AddMoneyForm();

            addForm.UserName = UserName;

            addForm.Balance = Balance;

            addForm.UserID = UserID;

            addForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            SendMoneyForm sendForm = new SendMoneyForm();

            sendForm.UserName = UserName;

            sendForm.Balance = Balance;

            sendForm.UserID = UserID;

            sendForm.Show();

            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();

            Login.Show();

            this.Close();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();

            form.UserName = UserName;

            form.Balance = Balance;

            form.UserID = UserID;

            form.Show();

            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();

            form.UserName = UserName;

            form.Balance = Balance;

            form.UserID = UserID;

            form.Show();

            this.Hide();
        }
    }
}
