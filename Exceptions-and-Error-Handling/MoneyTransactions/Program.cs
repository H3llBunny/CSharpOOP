using System;
using System.Linq;

namespace MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new List<BankAccount>();
            var bankAccountsInput = Console.ReadLine().Split(new char[] { ',', '-' });

            for (int i = 0; i < bankAccountsInput.Length; i++)
            {
                int bankAccountNumber = int.Parse(bankAccountsInput[i]);
                double bankAccountBalance = double.Parse(bankAccountsInput[i + 1]);
                bankAccounts.Add(new BankAccount(bankAccountNumber, bankAccountBalance));
                i++;
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();
                string command = tokens[0];
                int accountNumber = int.Parse(tokens[1]);
                double sumAmount = double.Parse(tokens[2]);
                try
                {
                    if (bankAccounts.Any(x => x.AccountNumber == accountNumber))
                    {
                        var currentBankAccount = bankAccounts.FirstOrDefault(x => x.AccountNumber == accountNumber);

                        switch (command)
                        {
                            case "Deposit":
                                currentBankAccount.Deposite(sumAmount);

                                break;
                            case "Withdraw":
                                currentBankAccount.Wirthdraw(sumAmount);
                                break;
                            default:
                                throw new ArgumentException("Invalid command!");
                                break;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid account!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
    }
}