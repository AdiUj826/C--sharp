using System;

class Person
{
    string name;
    int age;

    public Person()
    {
        name = "Unknown";
        age = 18;
    }

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    public void Show()
    {
        Console.WriteLine(name + " " + age);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Aditya", 25);
        p.Show();
    }
}
