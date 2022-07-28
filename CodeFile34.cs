//34. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

using System;
using System.Linq;
;

 class Pro34
{
    static void Main()
    {
        Console.Write("Input a first number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
    }

}














