using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using welllet.Classes;

namespace welllet.Forms
{
    public partial class AddMoneyForm : Form
    {
        public string UserName;
        public decimal Balance;
        public int UserID;
        public AddMoneyForm()
        {
            InitializeComponent();
        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserName;

            lblBalance.Text = "Balance: " + Balance + " EGP";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter amount");
                    return;
                }

                decimal amount = Convert.ToDecimal(txtAmount.Text);

                if (amount <= 0)
                {
                    MessageBox.Show("Amount must be greater than 0");
                    return;
                }

                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();

                string query =
                    @"UPDATE Users
          SET Balance = Balance + @Amount
          WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.Parameters.AddWithValue("@UserID", UserID);

                cmd.ExecuteNonQuery();
                string transactionQuery =
    @"INSERT INTO Transactions
      (SenderID, ReceiverID, Amount, TransactionType, TransactionDate)

      VALUES
      (NULL, @ReceiverID, @Amount, 'Add Money', GETDATE())";

                SqlCommand transactionCmd =
                    new SqlCommand(transactionQuery, con);

                transactionCmd.Parameters.AddWithValue("@ReceiverID", UserID);

                transactionCmd.Parameters.AddWithValue("@Amount", amount);

                transactionCmd.ExecuteNonQuery();

                Balance += amount;

                lblBalance.Text = "Balance: " + Balance + " EGP";

                MessageBox.Show("Money Added Successfully");

                txtAmount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.UserName = UserName;

            dashboard.Balance = Balance;

            dashboard.UserID = UserID;

            dashboard.Show();

            this.Close();
        }
    }
}
