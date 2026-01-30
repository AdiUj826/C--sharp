using System;

class Laptop
{
    string brand;
    int ram;

    public Laptop(string b, int r)
    {
        brand = b;
        ram = r;
    }

    public void Show()
    {
        Console.WriteLine(brand + " " + ram);
    }
}

class Program
{
    static void Main()
    {
        new Laptop("Dell", 16).Show();
    }
}

