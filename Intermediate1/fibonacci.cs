using System;
using System.Collections.Generic;

class FibonacciGenerator
{
    static void Main()
    {
        int n = 10; // Change this value to generate more Fibonacci numbers
        Console.WriteLine($"First {n} Fibonacci numbers:");

        foreach (int fibNumber in GenerateFibonacci(n))
        {
            Console.Write($"{fibNumber} ");
        }

        Console.ReadLine();
    }

    static IEnumerable<int> GenerateFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            yield return a;

            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
