using System;

class Book
{
    string title;
    int pages;

    public Book(string t, int p)
    {
        title = t;
        pages = p;
    }

    public void Show()
    {
        Console.WriteLine(title + " " + pages);
    }
}

class Program
{
    static void Main()
    {
        new Book("CSharp", 300).Show();
    }
}
