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

      
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName;

            lblBalance.Text = "Balance: " + Session.Balance + " EGP";
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            AddMoneyForm addForm = new AddMoneyForm();

           

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

            

            sendForm.Show();

            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.UserID = 0;

            Session.UserName = "";

            Session.Balance = 0;

            LoginForm login = new LoginForm();

            login.Show();

            this.Close();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();

           
            form.Show();

            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();

           

            form.Show();

            this.Hide();
        }
    }
}
