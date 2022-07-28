//1. Write a C# Sharp program to print Hello and your name in a separate line
using System;
class pro1
{
    static void Main()
    {
        Console.WriteLine("Hello_World..... ");
    }
}

//2. Write a C# Sharp program to print the sum of two numbers.
using System;
class Example
{
    static void Main()
    {
        int a = 10, b = 20, c;
        c = a + b;
        Console.WriteLine("Sum = " + c);
    }
}

//3. Write a C# Sharp program to print the result of dividing two numbers.
using System;
class div
{
    static void Main()
    {
        int b = 20;
         float a = 10, c;
        c = a / b;
        Console.WriteLine("Result " + c);
    }
}

/* 4. Write a C# Sharp program to print the result of the specified operations.
Test data: 
•	-1 + 4 * 6
•	  ( 35+ 5 ) % 7
•	  14 + -4 * 6 / 11
•	2 + 15 / 6 * 1 - 7 % 2 */
using System;
class Exercise4
{
    static void Main()
    {
        Console.WriteLine(-1 + 4 * 6);
        
        Console.WriteLine((35 + 5) % 7);
        
        Console.WriteLine(14 + -4 * 6 / 11);
        
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        
    }
}

//5. Write a C# Sharp program to swap two numbers…..
using System;
class SwapExample
{
    static void Main()
    {
        int a = 5, b = 6;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=30 (5*6)      
        b = a / b; //b=6 (30/6)      
        a = a / b; //a=6 (30/5)    
        Console.WriteLine("After swap a= " + a + " b= " + b);
    }
}

//6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;
class Exercise6
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Input the first number to multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2 * num3;
        Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                            num1, num2, num3, result);
    }
}

//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
using System;
class Exercise7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}

//8. Write a C# Sharp program that takes a number as input and print its multiplication table…
using System;
class Exercise8
{
     static void Main()
    {
        int j, n;
        Console.Write("Input the number : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
        for (j = 1; j <= 10; j++)
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);
        }
    }
}

//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average….
using System;
using System.IO;
class Exercise9
{
    static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}


//10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z…….
using System;
class Exercise10
{
    static void Main()
    {
        int number1, number2, number3;

        Console.Write("Enter first number - ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number - ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number - ");
        number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}
