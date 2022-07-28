//31. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.

using System;
using System.Linq;

class Pro31
{
    static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}









