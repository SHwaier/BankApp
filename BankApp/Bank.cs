using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Bank
    {
        Dictionary<int, Account> accounts = new Dictionary<int, Account>();

        public void addAccount(int id, Account account)
        {
            if (accounts.ContainsKey(id))
            {
                throw new ArgumentException("Account already exists!");
            }
            accounts.Add(id, account);
        }

        public void removeAccount(int id)
        {
            if (accounts.ContainsKey(id))
            {
                accounts.Remove(id);
            }
            else
            {
                throw new ArgumentException("Account is not in the system!");
            }
        }
        public Account getAccount(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                throw new Exception("Account doesn't exist!");
            }
            return accounts[id];
        }

        public void Deposit(int id, int amount)
        {
            getAccount(id).Deposit(amount);
        }
        public double WithDraw(int id, int amount)
        {
            return getAccount(id).WithDraw(amount);
        }


        public void Transfer(int sourceActId, int destActId, int amount)
        {
            if (WithDraw(sourceActId, amount) == amount)
            {
                Deposit(destActId, amount);
            }
        }

    }
}
