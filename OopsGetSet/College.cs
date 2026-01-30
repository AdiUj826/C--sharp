using System;

class College
{
    string name;
    string location;
    int code;

    public College()
    {
        name = "NA";
        location = "NA";
        code = 0;
    }

    public College(string n, string l, int c)
    {
        name = n;
        location = l;
        code = c;
    }

    public void PrintInfo()
    {
        Console.WriteLine(name);
        Console.WriteLine(location);
        Console.WriteLine(code);
    }
}

class Program
{
    static void Main()
    {
        College c = new College("ABC College", "Delhi", 1234);
        c.PrintInfo();
    }
}
