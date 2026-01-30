using System;

class Student
{
    int id;
    string name;

    public Student(int i, string n)
    {
        id = i;
        name = n;
    }

    public void Show()
    {
        Console.WriteLine(id + " " + name);
    }
}

class Program
{
    static void Main()
    {
        new Student(1, "Aditya").Show();
    }
}
