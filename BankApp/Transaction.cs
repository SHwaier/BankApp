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
    internal class Transaction
    {
        public STATUS status;
        public OPERATION operationAttempted;
        public DateTime dateTime;
        public string details;
        private static int _id;
        public int id { get; private set; }

        public Transaction(STATUS status, OPERATION operation, string details)
        {
            dateTime = DateTime.Now;
            id = _id;
            _id++;
            this.status = status;
            operationAttempted = operation;
            this.details = details;
        }
        public override string ToString()
        {
            return "Transaction #" + id;
        }
    }

}
