using System;
using System.IO;

class Program
{
    public static void SearchMail(ref string s)
    {
        int sharpIndex = s.IndexOf('#');
        if (sharpIndex > 0 && sharpIndex < s.Length - 1)
            s = s.Substring(sharpIndex + 1);
        else
            s = "";
    }

    public static void Main(string[] args)
    {
        string filePath = Console.ReadLine();
        string[] readLines = File.ReadAllLines(filePath);
        string[] emails = new string[readLines.Length];

        for (int i = 0; i < readLines.Length; i++)
        {
            string line = readLines[i];
            SearchMail(ref line);
            emails[i] = line;
        }

        File.WriteAllLines("emails.txt", emails);
    }
}