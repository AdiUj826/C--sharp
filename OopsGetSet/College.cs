using System;

class College
{
    private string name;
    private string location;
    private int collegeCode;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public int CollegeCode
    {
        get { return collegeCode; }
        set { collegeCode = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Location);
        Console.WriteLine(CollegeCode);
    }
}

class Program
{
    static void Main()
    {
        College c = new College();
        c.Name = "ABC College";
        c.Location = "Delhi";
        c.CollegeCode = 1234;
        c.PrintInfo();
    }
}
