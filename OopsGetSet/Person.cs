using System;

class Person
{
    string fullName;
    int age;
    string phone;

    public Person()
    {
        fullName = "NA";
        age = 0;
        phone = "Not Given";
    }

    public Person(string name, int a, string p)
    {
        fullName = name;
        age = a;
        phone = p;
    }

    public void PrintInfo()
    {
        Console.WriteLine(fullName);
        Console.WriteLine(age);
        Console.WriteLine(phone);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Yogesh", 24, "9699282032");
        p.PrintInfo();
    }
}
