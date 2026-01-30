using System;

class Movie
{
    string name;
    string language;

    public Movie(string n, string l)
    {
        name = n;
        language = l;
    }

    public void Show()
    {
        Console.WriteLine(name + " " + language);
    }
}

class Program
{
    static void Main()
    {
        new Movie("3 Idiots", "Hindi").Show();
    }
}
