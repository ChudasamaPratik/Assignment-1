//20. . Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

using System;


 class pro20
{
    static void Main()
    {
        int x, y;
        int result;

        Console.WriteLine("\nInput an integer:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input another integer:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
    }
}