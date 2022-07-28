//37. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
using System;
using System.Linq;

class pro37
{
static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        int n = 20;
        var val1 = Math.Abs(x - n);
        var val2 = Math.Abs(y - n);
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}


















