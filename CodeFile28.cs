//28. Write a C# program to convert a hexadecimal number to decimal number….

using System;

 class pro28
{
     static void Main()
    {

        string hexval = "4B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}







