//15. Write a C# program remove specified a character from a non-empty string using index of a character

using System;


 class pro15
{
    static void Main()
    {
        Console.WriteLine(remove_char("Atmiya University", 1));
        Console.WriteLine(remove_char("Atmiya University", 9));
        Console.WriteLine(remove_char("Atmiya University", 0));
    }
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}



