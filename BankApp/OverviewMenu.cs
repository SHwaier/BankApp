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
        public OverviewMenu()
        {
            InitializeComponent();
        }
        Transaction t;
        Transaction t2;
        private void OverviewMenu_Load(object sender, EventArgs e)
        {
            t = new Transaction(STATUS.SUCCESSFUL, OPERATION.DEPOSIT, "good money!!!!");
            t2 = new Transaction(STATUS.UNSUCCESSFUL, OPERATION.DEPOSIT, "bad money!!!!");
            listView1.Items.Add(t.ToString());
            listView1.Items.Add(t2.ToString());
        }
    }
}
