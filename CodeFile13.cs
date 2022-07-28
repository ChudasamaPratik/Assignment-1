//13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

using System;
 class pro13
{
     static void Main()
    {
        int x;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0}{0}{0}", x);
    }
}
