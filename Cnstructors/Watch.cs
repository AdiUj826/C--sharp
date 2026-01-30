using System;

class Watch
{
    string brand;
    int price;

    public Watch(string b, int p)
    {
        brand = b;
        price = p;
    }

    public void Show()
    {
        Console.WriteLine(brand + " " + price);
    }
}

class Program
{
    static void Main()
    {
        new Watch("Casio", 2000).Show();
    }
}
