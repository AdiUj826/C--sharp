using System;

class Person
{
    private string fullName;
    private int age;
    private string phone;

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine(FullName);
        Console.WriteLine(Age);
        Console.WriteLine(Phone);
    }
}

class Student
{
    private string studentName;
    private int studentAge;
    private int rollNumber;

    public string StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }

    public int StudentAge
    {
        get { return studentAge; }
        set { studentAge = value; }
    }

    public int RollNumber
    {
        get { return rollNumber; }
        set { rollNumber = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine(StudentName);
        Console.WriteLine(StudentAge);
        Console.WriteLine(RollNumber);
    }
}

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
        Person p = new Person();
        p.FullName = "Yogesh";
        p.Age = 24;
        p.Phone = "9699282032";
        p.PrintInfo();

        Console.WriteLine("----------------");

        Student s = new Student();
        s.StudentName = "Rahul";
        s.StudentAge = 20;
        s.RollNumber = 101;
        s.PrintInfo();

        Console.WriteLine("----------------");

        College c = new College();
        c.Name = "ABC College";
        c.Location = "Delhi";
        c.CollegeCode = 1234;
        c.PrintInfo();

        Console.WriteLine("----------------");

        Watch w = new Watch();
        w.Company = "Titan";
        w.Cost = 5000;
        w.PrintInfo();
    }
}
