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
    public partial class OverviewMenu : UserControl
    {
        List<Transaction> transactions = new List<Transaction>
        {
                new Transaction(STATUS.SUCCESSFUL, OPERATION.DEPOSIT, "Salary Deposit", 1500.00),
                new Transaction(STATUS.SUCCESSFUL, OPERATION.WITHDRAW, "ATM Withdrawal", 200.00),
                new Transaction(STATUS.PENDING, OPERATION.TRANSFER, "Transfer to Savings", 500.00),
                new Transaction(STATUS.UNSUCCESSFUL, OPERATION.WITHDRAW, "Failed ATM Withdrawal", 100.00),
                new Transaction(STATUS.SUCCESSFUL, OPERATION.DEPOSIT, "Gift Deposit", 300.00)
            };

        public OverviewMenu()
        {
            InitializeComponent();
            foreach (Transaction transaction in transactions)
            {
                TransactionCard transactionCard = new TransactionCard(transaction);
                // Set the margin to add spacing between cards
                transactionCard.Margin = new Padding(0, 0, 0, 10);

                // Set the AutoSize property to true
                transactionCard.AutoSize = true;

                // Set the MaximumSize property to ensure the card does not exceed the width of the FlowLayoutPanel
                transactionCard.MaximumSize = new Size(flowLayoutPanel1.ClientSize.Width - flowLayoutPanel1.Padding.Horizontal, 0);

                // Set a fixed height for the card
                transactionCard.Height = 100;
                flowLayoutPanel1.Controls.Add(transactionCard);
                

                //flowLayoutPanel1.Controls.Add(new TransactionCard(transaction));
            }
        }
        private void OverviewMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
