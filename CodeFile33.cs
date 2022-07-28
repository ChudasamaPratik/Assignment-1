//33. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.

using System;
using System.Linq;

public class Pro33
{
    static void Main()
    {
        Console.Write("Input a first number(<100): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number(>200): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((m < 100 && n > 200));
    }
}












