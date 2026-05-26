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
    public partial class ChangePasswordForm : Form
    {
        public string UserName;
        public decimal Balance;
        public int UserID;
        public ChangePasswordForm()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserName;

            lblBalance.Text = "Balance: " + Balance + " EGP";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCurrentPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Enter current password");
                    return;
                }

                if (txtNewPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Enter new password");
                    return;
                }

                if (txtConfirmPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Confirm your new password");
                    return;
                }

                if (txtNewPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters");
                    return;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }

                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();

                // التأكد من الباسورد الحالي
                string checkQuery =
                    @"SELECT * FROM Users
          WHERE UserID = @UserID
          AND Password = @Password";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@UserID", UserID);

                string currentHashedPassword =
                    HashHelper.HashPassword(txtCurrentPassword.Text);

                checkCmd.Parameters.AddWithValue("@Password",
                    currentHashedPassword);
                SqlDataReader reader = checkCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Current password is incorrect");

                    con.Close();

                    return;
                }

                reader.Close();

                // تحديث الباسورد
                string updateQuery =
                    @"UPDATE Users
          SET Password = @NewPassword
          WHERE UserID = @UserID";

                SqlCommand updateCmd =
                    new SqlCommand(updateQuery, con);

                string newHashedPassword =
                    HashHelper.HashPassword(txtNewPassword.Text);

                updateCmd.Parameters.AddWithValue("@NewPassword",
                    newHashedPassword);

                updateCmd.Parameters.AddWithValue("@UserID", UserID);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Password changed successfully");

                txtCurrentPassword.Clear();

                txtNewPassword.Clear();

                txtConfirmPassword.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
