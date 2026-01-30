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

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.FullName = "Yogesh";
        p.Age = 24;
        p.Phone = "9699282032";
        p.PrintInfo();
    }
}
