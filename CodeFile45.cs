//45. Write a C# program to check if an array contains an odd number.


using System;
using System.Linq;
 class pro45
{
     static void Main()
    {
        int[] n1 = { 2, 9, 7, 8, 7 };
        Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", n1));
        Console.WriteLine("Check if an array contains an odd number? " + even_odd(n1));
    }

    public static bool even_odd(int[] n1)
    {
        foreach (var n in n1)
        {
            if (n % 2 != 0)
                return true;
        }
        return false;

    }
}






