using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic6Task
{
    internal class Account
    {
        String PIN;
        int balance;
        String lastTransaction;

        public Account(String p, int b)
        {
            PIN = p;
            balance = b;
        }

        public Boolean checkPIN(String p)
        {
            if (PIN.Equals(p))
            {
                return true;
            }
            return false;
        }

        public int getBalance()
        {
            return balance;
        }

        public Boolean withdraw(int amount)
        {
            if (amount > balance)
            {
                return false;
            }
            lastTransaction = "Balance was " + balance + ". Withdraw " + amount;
            balance -= amount;
            lastTransaction += "\nNew Balance is " + balance;
            return true;
        }

        public String getLastTransaction()
        {
            if (lastTransaction != null)
            {
                return lastTransaction;
            }
            return "No transaction";
        }
    }
}
