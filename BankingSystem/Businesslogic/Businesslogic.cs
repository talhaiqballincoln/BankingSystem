using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Businesslogic
{
    // Enum for account type
    public enum AccountType
    {
        Personal,
        Business
    }

    // Enum for transaction type
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer
    }

    // Class for account
    public class Account
    {
        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public AccountType Type { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Account(int accountNumber, string userName, AccountType type)
        {
            AccountNumber = accountNumber;
            UserName = userName;
            Type = type;
            Balance = 0;
            Transactions = new List<Transaction>();
        }

        // Method to deposit cash
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction(TransactionType.Deposit, amount));
        }

        // Method to withdraw cash
        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add(new Transaction(TransactionType.Withdrawal, amount));
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }

        // Method to transfer funds to another account
        public bool Transfer(Account recipient, decimal amount)
        {
            if (Withdraw(amount))
            {
                recipient.Deposit(amount);
                Transactions.Add(new Transaction(TransactionType.Transfer, amount));
                return true;
            }
            else
            {
                Console.WriteLine("Transfer failed. Insufficient balance.");
                return false;
            }
        }
    }

    // Class for financial transaction
    public class Transaction
    {
        public TransactionType Type { get; }
        public decimal Amount { get; }
        public DateTime Timestamp { get; }

        public Transaction(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
            Timestamp = DateTime.Now;
        }
    }

    // Class for account services
    public class AccountServices
    {
        public static void ViewAccountInfo(Account account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"User Name: {account.UserName}");
            Console.WriteLine($"Account Type: {account.Type}");
            Console.WriteLine($"Current Balance: {account.Balance}");
            Console.WriteLine("Recent Transactions:");
            foreach (var transaction in account.Transactions)
            {
                Console.WriteLine($"{transaction.Timestamp} - {transaction.Type}: {transaction.Amount}");
            }
        }

        // Other account services methods can be implemented here
    }

    // Class for security and compliance
    public class SecurityAndCompliance
    {
        // Methods for implementing security and compliance measures can be added here
    }
}
