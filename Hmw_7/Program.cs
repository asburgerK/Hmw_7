using System;
using System.Globalization;




class Song 
{
    string name;
    string author;
    Song prev;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Song Prev
    {
        get { return prev; }
        set { prev = value; }
    }

    public string Title()
    {
        string title = name + "-" + author;
        return title;
    }
    public override bool Equals(object obj)
    {
        if (obj is not Song other) return false;
        return name == other.name && author == other.author;
    }

    public Song(string name, string author)
    {
        this.name = name;
        this.author = author;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Song s1 = new Song("Владимирский централ", "Михаил Круг");
        Song s2 = new Song("Кольщик", "Михаил Круг");
        Song s3 = new Song("Девочка-пай", "Михаил Круг");
        Song s4 = new Song("Жиган-лимон", "Михаил Круг");
        Song s5 = new Song("Приходите в мой дом", "Михаил Круг");
        bool areEqual = s1.Equals(s2);
    }   
}