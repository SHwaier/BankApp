using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public enum OPERATION
    {
        WITHDRAW,
        DEPOSIT,
        TRANSFER
    }
    public enum STATUS
    {
        SUCCESSFUL,
        UNSUCCESSFUL,
        PENDING
    }
    public class Transaction
    {
        public STATUS status { get; set; }
        public OPERATION operationAttempted { get; private set; }
        public DateTime dateTime { get; private set; }
        public string details { get; private set; }

        public double amount { get; private set; }

        private static int _id;
        public int id { get; private set; }

        public Transaction(STATUS status, OPERATION operation, string details, double amount)
        {
            dateTime = DateTime.Now;
            id = _id;
            _id++;
            this.status = status;
            operationAttempted = operation;
            this.details = details;
            this.amount = amount;
        }
        public override string ToString()
        {
            return "Transaction #" + id;
        }
    }
}
