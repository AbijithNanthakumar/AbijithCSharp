using System;

class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }
}

class Program
{
    static void Main()
    {
        BankAccount b = new BankAccount();
        b.Balance = 20000;
        Console.WriteLine(b.Balance);
        
    }
}