using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;
using welllet.Classes;


namespace welllet.Forms
{
    public partial class SendMoneyForm : Form
    {

        public SendMoneyForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();



            dashboard.Show();

            this.Close();
        }

        private void SendMoneyForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName;

            lblBalance.Text = "Balance: " + Session.Balance + " EGP";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            try
            {
                if (Validator.IsEmpty(txtReceiver.Text))
                {
                    MessageBox.Show("Enter receiver phone");
                    return;
                }

                if (Validator.IsEmpty(txtAmount.Text))
                {
                    MessageBox.Show("Enter amount");
                    return;
                }

                if (!Validator.IsValidPhone(txtReceiver.Text))
                {
                    MessageBox.Show("Invalid Egyptian phone number");
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
                transaction = con.BeginTransaction();


                string checkQuery =
                    @"SELECT * FROM Users
          WHERE PhoneNumber = @Phone";

                SqlCommand checkCmd =
                    new SqlCommand(checkQuery, con, transaction);
                checkCmd.Parameters.AddWithValue("@Phone", txtReceiver.Text);

                SqlDataReader reader = checkCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Receiver not found");

                    con.Close();

                    return;
                }

                int receiverID = Convert.ToInt32(reader["UserID"]);
                if (txtReceiver.Text == Session.UserPhone)
                {
                    MessageBox.Show("You cannot send money to yourself");

                    con.Close();

                    return;
                }
                reader.Close();



                if (amount > Session.Balance)
                {
                    MessageBox.Show("Insufficient balance");

                    con.Close();

                    return;
                }


                string senderQuery =
                    @"UPDATE Users
          SET Balance = Balance - @Amount
          WHERE UserID = @UserID";

                SqlCommand senderCmd =
                    new SqlCommand(senderQuery, con, transaction);
                senderCmd.Parameters.AddWithValue("@Amount", amount);

                senderCmd.Parameters.AddWithValue("@UserID", Session.UserID);

                senderCmd.ExecuteNonQuery();


                string receiverQuery =
                    @"UPDATE Users
          SET Balance = Balance + @Amount
          WHERE UserID = @ReceiverID";

                SqlCommand receiverCmd =
                    new SqlCommand(receiverQuery, con, transaction);
                receiverCmd.Parameters.AddWithValue("@Amount", amount);

                receiverCmd.Parameters.AddWithValue("@ReceiverID", receiverID);

                receiverCmd.ExecuteNonQuery();
                string transactionQuery =
    @"INSERT INTO Transactions
      (SenderID, ReceiverID, Amount, TransactionType, TransactionDate)

      VALUES
      (@SenderID, @ReceiverID, @Amount, 'Send Money', GETDATE())";
                SqlCommand transactionCmd =
    new SqlCommand(transactionQuery, con, transaction);
                transactionCmd.Parameters.AddWithValue("@SenderID", Session.UserID);

                transactionCmd.Parameters.AddWithValue("@ReceiverID", receiverID);

                transactionCmd.Parameters.AddWithValue("@Amount", amount);

                transactionCmd.ExecuteNonQuery();
                transaction.Commit();


                Session.Balance -= amount;

                lblBalance.Text = "Balance: " + Session.Balance + " EGP";

                MessageBox.Show("Money Sent Successfully");

                txtReceiver.Clear();

                txtAmount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }

                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
       !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtReceiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceiver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
        !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
