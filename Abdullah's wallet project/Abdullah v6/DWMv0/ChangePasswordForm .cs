using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Security.Policy;

namespace DWM_v0
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Current Password";
            label2.Text = "New Password";
            label3.Text = "Confirm Password";
        }

        // =========================
        // SAVE BUTTON (Change Password)
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = textBox1.Text;
                string newPassword = textBox2.Text;
                string confirmPassword = textBox3.Text;

                // =========================
                // VALIDATION
                // =========================
                if (Validator.IsEmpty(currentPassword) ||
                    Validator.IsEmpty(newPassword) ||
                    Validator.IsEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                if (!Session.CurrentUser.CheckPassword(currentPassword))
                {
                    MessageBox.Show("Current password is incorrect");
                    return;
                }

                if (!Validator.IsValidPassword(newPassword))
                {
                    MessageBox.Show("Password is too weak (min 4 characters)");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirmation do not match");
                    return;
                }

                // =========================
                // UPDATE DATABASE
                // =========================
                DBmanager db = new DBmanager();

                Session.CurrentUser.Password = newPassword;

                User user = Session.CurrentUser;

                db.UpdateUserTable(user);

                MessageBox.Show("Password changed successfully");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // CANCEL BUTTON
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }
    }
}