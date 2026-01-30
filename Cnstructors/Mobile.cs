using System;

class Mobile
{
    string model;
    int price;

    public Mobile(string m, int p)
    {
        model = m;
        price = p;
    }

    public void Show()
    {
        Console.WriteLine(model + " " + price);
    }
}

class Program
{
    static void Main()
    {
        new Mobile("iPhone", 60000).Show();
    }
}
