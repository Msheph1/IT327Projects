using System;
using System.Collections.Generic;
//Max Wilson
class Program
{
    static void Main()
    {
        //Prompt user for an N value to calculate to
        //Using double to allow for larger fibonacci values
        Console.WriteLine("Enter a value for N: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine($"First {n} Fibonacci numbers:");

        //Iterates through the function using yield statements
        foreach (double fibNumber in GenerateFibonacci(n))
        {
            //Print number
            Console.Write($"{fibNumber} ");
        }

        Console.ReadLine();
    }

    static IEnumerable<double> GenerateFibonacci(double n)
    {
        double a = 0, b = 1;

        for (double i = 0; i < n; i++)
        {   //Use Yield Return generator to return fibonacci values from function
            yield return a;

            double temp = a;
            a = b;
            b = temp + b;
        }
    }
}