using System;

class Program
{

    public static string Reverse(string input)
    {
        char [] chars = input.ToCharArray();
        Array.Reverse(chars);

        return new string (chars);
    }
    public static void Main(string[] args)
    {

        string r = "Heeloo";
        Console.WriteLine(Reverse(r));
    }
}