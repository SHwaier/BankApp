using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class TransactionCard : UserControl
    {
        public TransactionCard(Transaction transaction)
        {
            InitializeComponent();

            titleLbl.Text = transaction.operationAttempted.ToString() + " : " + transaction.status;
            dateLbl.Text = transaction.dateTime.ToString("MMM dd, yyyy | h:mmtt");
            descLbl.Text = transaction.details;
            amountLbl.Text = transaction.operationAttempted == OPERATION.DEPOSIT ? "+$" : "-$";
            amountLbl.Text += transaction.amount;
            amountLbl.ForeColor = transaction.operationAttempted == OPERATION.DEPOSIT ? Color.Green : Color.Red;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
