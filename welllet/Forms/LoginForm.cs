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
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password");
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

                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Success");
                    DashboardForm dashboard = new DashboardForm();

                    dashboard.UserName = reader["FullName"].ToString();

                    dashboard.Balance = Convert.ToDecimal(reader["Balance"]);
                    dashboard.UserID = Convert.ToInt32(reader["UserID"]);

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
    }
}

