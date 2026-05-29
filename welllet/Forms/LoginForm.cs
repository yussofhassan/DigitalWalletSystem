using welllet.Forms;
using Microsoft.Data.SqlClient;
using welllet.Classes;
namespace welllet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (Validator.IsEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            if (!Validator.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid Egyptian phone number");
                return;
            }

            try
            {
                DatabaseManager db = new DatabaseManager();

                SqlConnection con = db.GetConnection();

                con.Open();

                string query =
                    @"SELECT * FROM Users
          WHERE PhoneNumber = @PhoneNumber
          AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                string hashedPassword =
     HashHelper.HashPassword(txtPassword.Text);

                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Success");
                    DashboardForm dashboard = new DashboardForm();



                    Session.UserName = reader["FullName"].ToString();

                    Session.UserPhone =
    reader["PhoneNumber"].ToString();

                    Session.Balance = Convert.ToDecimal(reader["Balance"]);

                    Session.UserID = Convert.ToInt32(reader["UserID"]);
                    reader.Close();

                    txtPhone.Clear();

                    txtPassword.Clear();

                    dashboard.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong phone or password");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
        !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

