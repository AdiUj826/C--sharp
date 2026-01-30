using System;

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

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.StudentName = "Rahul";
        s.StudentAge = 20;
        s.RollNumber = 101;
        s.PrintInfo();
    }
}
