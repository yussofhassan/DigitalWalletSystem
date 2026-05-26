using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class RegisterForm : Form
    {
        private readonly DBmanager _dbManager;

        public RegisterForm()
        {
            InitializeComponent();
            _dbManager = new DBmanager();
        }

        // =========================
        // REGISTER BUTTON (button1)
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string phone = textBox2.Text;
                string password = textBox3.Text;
                string confirmPassword = textBox4.Text;
                string balanceText = textBox5.Text;

                // =========================
                // VALIDATION
                // =========================
                if (Validator.IsEmpty(name) ||
                    Validator.IsEmpty(phone) ||
                    Validator.IsEmpty(password) ||
                    Validator.IsEmpty(confirmPassword) ||
                    Validator.IsEmpty(balanceText))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                if (!Validator.IsValidName(name))
                {
                    MessageBox.Show("Invalid name");
                    return;
                }

                if (!Validator.IsValidPhone(phone))
                {
                    MessageBox.Show("Invalid phone number");
                    return;
                }

                if (!Validator.IsValidPassword(password))
                {
                    MessageBox.Show("Weak password (min 4 chars)");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }

                if (!decimal.TryParse(balanceText, out decimal balance))
                {
                    MessageBox.Show("Invalid balance");
                    return;
                }

                if (!Validator.IsValidAmount(balance))
                {
                    MessageBox.Show("Balance must be greater than 0");
                    return;
                }

                // =========================
                // CHECK IF USER EXISTS
                // =========================

                User user = User.GetUserByPhone(phone);

                if (user != null)
                {
                    MessageBox.Show("User already exists");
                    return;
                }

                // =========================
                // INSERT NEW USER
                // =========================
                DBmanager db = new DBmanager();

                User newUser = new User();

                newUser.FullName = name;
                newUser.PhoneNumber = phone;
                newUser.Password = password;
                newUser.Balance = balance;

                db.InsertToUserTable(newUser);

                MessageBox.Show("Registration Successful");

                // BACK TO LOGIN
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // CANCEL BUTTON (button2)
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}