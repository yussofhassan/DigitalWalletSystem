using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =========================
        // LOGIN BUTTON (button1)
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = textBox1.Text;
                string password = textBox2.Text;

                // =========================
                // VALIDATION
                // =========================
                if (Validator.IsEmpty(phone) || Validator.IsEmpty(password))
                {
                    MessageBox.Show("Please enter phone and password");
                    return;
                }

                if (!Validator.IsValidPhone(phone))
                {
                    MessageBox.Show("Invalid phone number");
                    return;
                }

                // =========================
                // GET USER FROM DB
                // =========================

                User user = User.GetUserByPhone(phone);

                if (user == null)
                {
                    MessageBox.Show("User not found");
                    return;
                }

                // =========================
                // CHECK PASSWORD
                // =========================
                if (!user.CheckPassword(password))
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }

                // =========================
                // SET SESSION
                // =========================
                Session.CurrentUser = user;

                //MessageBox.Show("Login Successful");

                // OPEN DASHBOARD
                DashboardForm dash = new DashboardForm();
                dash.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // EXIT BUTTON (button2)
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // =========================
        // REGISTER BUTTON (button3)
        // =========================
        private void button3_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide(); 
        }
        DBmanager Obj = new DBmanager();

        // =========================
        // FORM LOAD
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}