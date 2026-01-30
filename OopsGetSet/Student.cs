using System;

class Student
{
    string name;
    int age;
    int rollNo;

    public Student()
    {
        name = "NA";
        age = 0;
        rollNo = 0;
    }

    public Student(string n, int a, int r)
    {
        name = n;
        age = a;
        rollNo = r;
    }

    public void PrintInfo()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(rollNo);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Rahul", 20, 101);
        s.PrintInfo();
    }
}


