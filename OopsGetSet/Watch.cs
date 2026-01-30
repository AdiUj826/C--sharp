using System;

class Watch
{
    private string company;
    private int cost;

    public string Company
    {
        get { return company; }
        set { company = value; }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine(Company);
        Console.WriteLine(Cost);
    }
}

class Program
{
    static void Main()
    {
        Watch w = new Watch();
        w.Company = "Titan";
        w.Cost = 5000;
        w.PrintInfo();
    }
}
