using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransactions
{
    public class BankAccount
    {
        public BankAccount(int accountNumber, double balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public int AccountNumber { get; }

        private double Balance { get; set; }

        public void Deposite(double sum)
        {
            this.Balance += sum;
            Console.WriteLine($"Account {this.AccountNumber} has new balance: {this.Balance:F2}");
        }

        public void Wirthdraw(double sum)
        {
            if (this.Balance >= sum)
            {
                this.Balance -= sum;
                Console.WriteLine($"Account {this.AccountNumber} has new balance: {this.Balance:F2}");
            }
            else
            {
                throw new ArgumentException("Insufficient balance!");
            }
        }
    }
}
