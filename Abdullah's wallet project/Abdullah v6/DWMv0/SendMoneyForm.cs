using System;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class SendMoneyForm : Form
    {
        DashboardForm _dashboardForm;
        public SendMoneyForm(DashboardForm dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void SendMoneyForm_Load(object sender, EventArgs e)
        {
            try
            {
                Session.CurrentUser = User.GetUserByPhone(Session.CurrentUser.PhoneNumber);


                label1.Text = "To (Phone Number):";
                label2.Text = "Amount:";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // SEND BUTTON
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = textBox1.Text;
                string amountText = textBox2.Text;

                // =========================
                // VALIDATION
                // =========================
                if (Validator.IsEmpty(phone) || Validator.IsEmpty(amountText))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                if (!Validator.IsValidPhone(phone))
                {
                    MessageBox.Show("Invalid phone number");
                    return;
                }

                if (!Validator.IsNumeric(amountText))
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }

                decimal amount = Convert.ToDecimal(amountText);

                if (!Validator.IsValidAmount(amount))
                {
                    MessageBox.Show("Amount must be greater than 0");
                    return;
                }

                if(phone == Session.CurrentUser.PhoneNumber)
                {
                    MessageBox.Show("Can't Transfer to your self");
                    return;
                }

                // =========================
                // GET RECEIVER
                // =========================

                User receiver = User.GetUserByPhone(phone);

                if (receiver == null)
                {
                    MessageBox.Show("Receiver not found");
                    return;
                }

                // =========================
                // CHECK BALANCE
                // =========================
                if (!Session.CurrentUser.Withdraw(amount))
                {
                    MessageBox.Show("Insufficient balance");
                    return;
                }

                //        // =========================
                //        // PROCESS TRANSFER
                //        // =========================
                receiver.Deposit(amount);

                // Update DB
                Session.CurrentUser.UpdateBalance();
                receiver.UpdateBalance();

                _dashboardForm.updateBalanceText();

                // Save Transaction
                Transaction t = new Transaction();
                t.SenderID = Session.CurrentUser.UserID;
                t.ReceiverID = receiver.UserID;
                t.Amount = amount;
                t.Type = "Transfer";
                t.Save();

                MessageBox.Show("Money Sent Successfully");

                textBox1.Clear();
                textBox2.Clear();

                this.Hide();
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
            _dashboardForm.updateBalanceText();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SendMoneyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dashboardForm.updateBalanceText();
            this.Hide();
        }
    }
}