//19. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number…
using System;
class pro19
{
    static void Main()
    {
        Console.WriteLine(result(13, 40));
        Console.WriteLine(result(50, 21));
        Console.WriteLine(result(0, 23));
    }

    public static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }
}
