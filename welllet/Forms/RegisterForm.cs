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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name");
                return;
            }

            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits");
                return;
            }

            if (!txtPhone.Text.StartsWith("01"))
            {
                MessageBox.Show("Invalid Egyptian phone number");
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password");
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                return;
            }

            if (txtConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please confirm password");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender");
                return;
            }

            try
            {
                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();

                string query =
                    @"INSERT INTO Users
        (FullName, PhoneNumber, Password, Balance, Gender, BirthDate)

        VALUES
        (@FullName, @PhoneNumber, @Password, @Balance, @Gender, @BirthDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);

                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.Parameters.AddWithValue("@Balance", 0);

                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);

                cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Account Created Successfully");
                LoginForm Login = new LoginForm();

                Login.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();

            Login.Show();

            this.Hide();
        }
    }
}
