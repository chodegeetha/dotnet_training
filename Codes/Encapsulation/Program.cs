using System;

// Class demonstrating encapsulation
public class BankAccount
{
    // Private member variables (encapsulated data)
    private string accountHolder;
    private double balance;

    // Constructor to initialize the object
    public BankAccount(string accountHolder, double initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    // Public methods to interact with encapsulated data

    // Getter method for accountHolder (read-only)
    public string GetAccountHolder()
    {
        return accountHolder;
    }

    // Getter method for balance (read-only)
    public double GetBalance()
    {
        return balance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }
}

class Program
{
    static void Main()
    {
        
        BankAccount myAccount = new BankAccount("John Doe", 1000.00);

        
        Console.WriteLine($"Account Holder: {myAccount.GetAccountHolder()}");
        Console.WriteLine($"Initial Balance: {myAccount.GetBalance():C}");

        myAccount.Deposit(500.00);
        myAccount.Withdraw(200.00);
    }
}

