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
        public string UserName;
        public decimal Balance;
        public int UserID;
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserName;

            lblBalance.Text = "Balance: " + Balance + " EGP";

            try
            {
                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();
                string query =
                    @"SELECT

    CASE

        WHEN TransactionType = 'Add Money'
        THEN 'Added'

        WHEN SenderID = @UserID
        THEN 'Sent'

        WHEN ReceiverID = @UserID
        THEN 'Received'

    END
    AS TransactionStatus,

    Amount,

    TransactionDate

    FROM Transactions

    WHERE SenderID = @UserID
    OR ReceiverID = @UserID

    ORDER BY TransactionDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserID", UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvTransactions.DataSource = dt;
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

            dashboard.UserName = UserName;

            dashboard.Balance = Balance;

            dashboard.UserID = UserID;

            dashboard.Show();

            this.Close();
        }
    }
}
