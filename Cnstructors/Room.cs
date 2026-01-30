using System;

class Room
{
    int number;
    string type;

    public Room(int n, string t)
    {
        number = n;
        type = t;
    }

    public void Show()
    {
        Console.WriteLine(number + " " + type);
    }
}

class Program
{
    static void Main()
    {
        new Room(101, "AC").Show();
    }
}
