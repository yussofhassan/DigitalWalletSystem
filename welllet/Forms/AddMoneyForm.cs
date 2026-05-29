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

        public AddMoneyForm()
        {
            InitializeComponent();
        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName;

            lblBalance.Text = "Balance: " + Session.Balance + " EGP";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsEmpty(txtAmount.Text))
                {
                    MessageBox.Show("Please enter amount");
                    return;
                }
                decimal amount;

                if (!decimal.TryParse(txtAmount.Text, out amount))
                {
                    MessageBox.Show("Enter a valid amount");
                    return;
                }
                if (!Validator.IsValidAmount(amount))
                {
                    MessageBox.Show("Amount must be greater than zero");
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

                cmd.Parameters.AddWithValue("@UserID", Session.UserID);
                cmd.ExecuteNonQuery();
                string transactionQuery =
    @"INSERT INTO Transactions
      (SenderID, ReceiverID, Amount, TransactionType, TransactionDate)

      VALUES
      (NULL, @ReceiverID, @Amount, 'Add Money', GETDATE())";

                SqlCommand transactionCmd =
                    new SqlCommand(transactionQuery, con);

                transactionCmd.Parameters.AddWithValue("@ReceiverID", Session.UserID);
                transactionCmd.Parameters.AddWithValue("@Amount", amount);

                transactionCmd.ExecuteNonQuery();

                Session.Balance += amount;

                lblBalance.Text =
                    $"Balance: {Session.Balance} EGP";
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



            dashboard.Show();

            this.Hide();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
       !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
