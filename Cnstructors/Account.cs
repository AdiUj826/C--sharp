using System;

class Account
{
    int accNo;
    decimal balance;

    public Account(int a, decimal b)
    {
        accNo = a;
        balance = b;
    }

    public void Show()
    {
        Console.WriteLine(accNo + " " + balance);
    }
}

class Program
{
    static void Main()
    {
        new Account(123, 50000).Show();
    }
}
