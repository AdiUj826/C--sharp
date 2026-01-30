using System;

class Circle
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public void Show()
    {
        Console.WriteLine(radius);
    }
}

class Program
{
    static void Main()
    {
        new Circle(5).Show();
    }
}

