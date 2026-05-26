using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class AddMoneyForm : Form
    {
        DashboardForm _dashboardForm;
        public AddMoneyForm(DashboardForm dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            try
            {

                Session.CurrentUser = User.GetUserByPhone(Session.CurrentUser.PhoneNumber);

                label1.Text = "Current Balance: " +
                    Session.CurrentUser.Balance.ToString() + " EGP";

                label2.Text = "Enter Amount:";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // ADD BUTTON
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter amount");
                return;
            }

            if (!Validator.IsNumeric(textBox1.Text))
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            decimal amount = Convert.ToDecimal(textBox1.Text);

            if (!Validator.IsValidAmount(amount))
            {
                MessageBox.Show("Amount must be greater than 0");
                return;
            }

            // Add money
            Session.CurrentUser.Deposit(amount);
            Session.CurrentUser.UpdateBalance();

            _dashboardForm.updateBalanceText();


            // Save transaction
            Transaction t = new Transaction();
            t.SenderID = Session.CurrentUser.UserID;
            t.ReceiverID = Session.CurrentUser.UserID;
            t.Amount = amount;
            t.Type = "Deposit";
            t.Save();

            MessageBox.Show("Money Added Successfully," + "New Balance is: " + Session.CurrentUser.Balance.ToString() + "EGP");

            // refresh label
            label1.Text = "Current Balance: " + Session.CurrentUser.Balance.ToString() + " EGP";

            textBox1.Clear();

            this.Hide();
        }

        // =========================
        // CANCEL BUTTON
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            _dashboardForm.updateBalanceText();
            this.Hide();
        }

        private void AddMoneyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dashboardForm.updateBalanceText();
            this.Hide();
        }
    }
}