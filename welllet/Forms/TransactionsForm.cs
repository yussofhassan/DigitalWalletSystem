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
    public partial class TransactionsForm : Form
    {
       
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName;

            lblBalance.Text = "Balance: " + Session.Balance + " EGP";

            try
            {
                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();
                string query =
 @"SELECT

CASE

    WHEN T.TransactionType = 'Add Money'
    THEN 'Added'

    WHEN T.SenderID = @UserID
    THEN 'Sent'

    WHEN T.ReceiverID = @UserID
    THEN 'Received'

END AS TransactionStatus,

CASE

    WHEN T.TransactionType = 'Add Money'
    THEN '---'

    WHEN T.SenderID = @UserID
    THEN ReceiverUser.PhoneNumber

    WHEN T.ReceiverID = @UserID
    THEN SenderUser.PhoneNumber

END AS OtherParty,

T.Amount,

T.TransactionDate

FROM Transactions T

LEFT JOIN Users SenderUser
ON T.SenderID = SenderUser.UserID

LEFT JOIN Users ReceiverUser
ON T.ReceiverID = ReceiverUser.UserID

WHERE T.SenderID = @UserID
OR T.ReceiverID = @UserID

ORDER BY T.TransactionDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserID", Session.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvTransactions.DataSource = dt;

                dgvTransactions.Columns["TransactionStatus"].HeaderText = "Type";

                dgvTransactions.Columns["OtherParty"].HeaderText = "Other Party";

                dgvTransactions.Columns["Amount"].HeaderText = "Amount";

                dgvTransactions.Columns["TransactionDate"].HeaderText = "Date";
               

                
                dgvTransactions.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

                dgvTransactions.RowTemplate.Height = 35;

                dgvTransactions.Font =
                    new Font("Segoe UI", 11);

                dgvTransactions.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 11, FontStyle.Bold);

                dgvTransactions.EnableHeadersVisualStyles = false;

                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.DarkBlue;

                dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;

                dgvTransactions.BackgroundColor = Color.White;

                dgvTransactions.BorderStyle = BorderStyle.None;

                dgvTransactions.AllowUserToAddRows = false;

                dgvTransactions.ReadOnly = true;

                dgvTransactions.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

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
    }
}
