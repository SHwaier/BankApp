using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Account
    {
        public double funds { get; protected set; }
        public Person person { get; protected set; }
        private static int _id;
        public int accountNumber { get; private set; }
        LinkedList<Transaction> transactions = new LinkedList<Transaction>();


        public Account(double funds, Person person)
        {
            accountNumber = _id;
            _id++;
            this.funds = funds;
            this.person = person;
            accountNumber++;
        }


        public double WithDraw(double amount)
        {
            Transaction transaction;
            if (amount <= 0)
            {
                transaction = new Transaction(STATUS.UNSUCCESSFUL, OPERATION.WITHDRAW, "Declined due to invalid input!", amount);
                return 0;
            }
            else if (amount > funds)
            {
                transaction = new Transaction(STATUS.UNSUCCESSFUL, OPERATION.WITHDRAW, "Declind due to insufficient Funds.", amount);
                throw new ArgumentException("Insufficient Funds!");
            }
            transaction = new Transaction(STATUS.SUCCESSFUL, OPERATION.WITHDRAW, "A withdraw of $" + amount + " was made.", amount);
            funds -= amount;
            transactions.AddFirst(transaction);
            return amount;
        }

        public void Deposit(double amount)
        {
            Transaction transaction;
            if (amount <= 0)
            {
                transaction = new Transaction(STATUS.UNSUCCESSFUL, OPERATION.DEPOSIT, "Declined due to invalid input!", amount);
                return;
            }
            transaction = new Transaction(STATUS.SUCCESSFUL, OPERATION.DEPOSIT, "Successfully deposited $" + amount + ".", amount);
            funds += amount;
        }

        public double getFunds()
        {
            return funds;
        }
        public int getAccountNumber()
        {
            return accountNumber;
        }
    }
}
