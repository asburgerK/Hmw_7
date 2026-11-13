using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Console.ReadLine();
        string file = "output";
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            content = content.ToUpper();
            File.WriteAllText(file, content);

        }

        else
        {
            Console.WriteLine("File not found.");
        }



    }
}