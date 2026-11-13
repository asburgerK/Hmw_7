using System;

class Program
{
    public static bool IsFormattable(object obj)
    {
        if(obj is IFormattable)
        {
            Console.WriteLine("object is formattable.");
            return true;
        }
        else
        {
            Console.WriteLine("object is not formattable.");
            return false;
        }
    }
}
    



