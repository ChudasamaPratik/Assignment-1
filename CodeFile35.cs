//35. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".

using System;

using System.Linq;

class Pro35
{
    static void Main()
    {
        string str = "PHP Tutorial";
        Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
    }
}
















