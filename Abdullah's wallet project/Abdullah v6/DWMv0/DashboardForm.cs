using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void updateBalanceText()
        {
            try
            {
                label3.Text = Session.CurrentUser.Balance.ToString() + " EGP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // FORM LOAD
        // =========================
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session.CurrentUser != null)
                {
                    label1.Text = "Welcome, " + Session.CurrentUser.FullName;

                    label2.Text = "Current Balance";

                    label3.Text = Session.CurrentUser.Balance.ToString() + " EGP";
                }
                else
                {
                    MessageBox.Show("Session expired");

                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // ADD MONEY (Button1)
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddMoneyForm addMoneyForm = new AddMoneyForm(this);
                addMoneyForm.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // SEND MONEY (Button2)
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SendMoneyForm f = new SendMoneyForm(this);
                f.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // RECENT TRANSACTIONS (Button3)
        // =========================
        private void button3_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();

            List<Transaction> transactions = transaction.GetLastFive(Session.CurrentUser.UserID);

            try
            {
                TransactionForm f = new TransactionForm(transactions);
                f.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // LOGOUT (Button4)
        // =========================
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.Show();
            this.Hide();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //Session.Clear();

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}