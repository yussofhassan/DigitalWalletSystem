using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWM_v0
{
    public partial class TransactionForm : Form
    {
        private List<Transaction> _transactions;

        public TransactionForm(List<Transaction> transactions)
        {
            InitializeComponent();

            _transactions = transactions;

            LoadTransactions();
        }

        private void LoadTransactions()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _transactions;
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
