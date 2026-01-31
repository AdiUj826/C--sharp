using System;

class College
{
    private string name;
    private string location;
    private int collegeCode;

    public College()
    {
        name = "NA";
        location = "NA";
        collegeCode = 0;
    }

    public College(string name, string location, int collegeCode)
    {
        this.name = name;
        this.location = location;
        this.collegeCode = collegeCode;
    }

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
        Console.WriteLine("-----------");
    }
}

class Program
{
    static void Main()
    {
        College c1 = new College();
        c1.PrintInfo();

        College c2 = new College("ABC College", "Delhi", 1234);
        c2.PrintInfo();
    }
}
