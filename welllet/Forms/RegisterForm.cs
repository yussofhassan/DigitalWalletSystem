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
            dtBirthDate.MaxDate = DateTime.Today.AddYears(-10);
        }
        


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name");
                return;
            }

            if (Validator.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (!Validator.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid Egyptian phone number");
                return;
            }

            if (Validator.IsEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters");
                return;
            }

            if (Validator.IsEmpty(txtConfirmPassword.Text))
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

            if (dtBirthDate.Value > DateTime.Today.AddYears(-10))
            {
                MessageBox.Show("Age must be at least 10 years");
                return;
            }

            try
            {
                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();

                string checkPhoneQuery =
    @"SELECT COUNT(*)
      FROM Users
      WHERE PhoneNumber = @PhoneNumber";

                SqlCommand checkCmd =
                    new SqlCommand(checkPhoneQuery, con);

                checkCmd.Parameters.AddWithValue(
                    "@PhoneNumber",
                    txtPhone.Text);

                int count =
                    Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show(
                        "Phone number already exists");

                    con.Close();

                    return;
                }
                string query =

                    @"INSERT INTO Users
        (FullName, PhoneNumber, Password, Balance, Gender, BirthDate)

        VALUES
        (@FullName, @PhoneNumber, @Password, @Balance, @Gender, @BirthDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);

                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                string hashedPassword =
     HashHelper.HashPassword(txtPassword.Text);

                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                cmd.Parameters.AddWithValue("@Balance", 0);

                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);

                cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Account Created Successfully");
                txtFullName.Clear();

                txtPhone.Clear();

                txtPassword.Clear();

                txtConfirmPassword.Clear();

                cmbGender.SelectedIndex = -1;

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

            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
        !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
       !char.IsLetter(e.KeyChar) &&
       e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
