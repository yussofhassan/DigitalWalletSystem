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
        public string UserName;
        public decimal Balance;
        public int UserID;
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

            dashboard.UserName = UserName;

            dashboard.Balance = Balance;

            dashboard.UserID = UserID;

            dashboard.Show();

            this.Close();
        }

        private void SendMoneyForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserName;

            lblBalance.Text = "Balance: " + Balance + " EGP";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReceiver.Text.Trim() == "")
                {
                    MessageBox.Show("Enter receiver phone");
                    return;
                }

                if (txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter amount");
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

                // التأكد إن الرقم موجود
                string checkQuery =
                    @"SELECT * FROM Users
          WHERE PhoneNumber = @Phone";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@Phone", txtReceiver.Text);

                SqlDataReader reader = checkCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Receiver not found");

                    con.Close();

                    return;
                }

                int receiverID = Convert.ToInt32(reader["UserID"]);

                reader.Close();

                // منع التحويل لنفس الشخص
                if (receiverID == UserID)
                {
                    MessageBox.Show("You cannot send money to yourself");

                    con.Close();

                    return;
                }

                // التأكد من الرصيد
                if (amount > Balance)
                {
                    MessageBox.Show("Insufficient balance");

                    con.Close();

                    return;
                }

                // خصم من المرسل
                string senderQuery =
                    @"UPDATE Users
          SET Balance = Balance - @Amount
          WHERE UserID = @UserID";

                SqlCommand senderCmd = new SqlCommand(senderQuery, con);

                senderCmd.Parameters.AddWithValue("@Amount", amount);

                senderCmd.Parameters.AddWithValue("@UserID", UserID);

                senderCmd.ExecuteNonQuery();

                // إضافة للمستقبل
                string receiverQuery =
                    @"UPDATE Users
          SET Balance = Balance + @Amount
          WHERE UserID = @ReceiverID";

                SqlCommand receiverCmd = new SqlCommand(receiverQuery, con);

                receiverCmd.Parameters.AddWithValue("@Amount", amount);

                receiverCmd.Parameters.AddWithValue("@ReceiverID", receiverID);

                receiverCmd.ExecuteNonQuery();
                string transactionQuery =
    @"INSERT INTO Transactions
      (SenderID, ReceiverID, Amount, TransactionType, TransactionDate)

      VALUES
      (@SenderID, @ReceiverID, @Amount, 'Send Money', GETDATE())";

                SqlCommand transactionCmd =
                    new SqlCommand(transactionQuery, con);

                transactionCmd.Parameters.AddWithValue("@SenderID", UserID);

                transactionCmd.Parameters.AddWithValue("@ReceiverID", receiverID);

                transactionCmd.Parameters.AddWithValue("@Amount", amount);

                transactionCmd.ExecuteNonQuery();

                // تحديث الرصيد داخل الفورم
                Balance -= amount;

                lblBalance.Text = "Balance: " + Balance + " EGP";

                MessageBox.Show("Money Sent Successfully");

                txtReceiver.Clear();

                txtAmount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
