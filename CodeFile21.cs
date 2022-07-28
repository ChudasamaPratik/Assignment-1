//21. Write a C# program to check if an given integer is within 20 of 100 or 200….

using System;

 class pro21
{
    static void Main()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(result(x));
    }

    public static bool result(int n)
    {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
        return false;
    }
}

