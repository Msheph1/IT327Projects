// Written by Jacob Nothvogel
using System;

// This defines the delegate
public delegate void OperationDelegate();

class Program
{
    static void Main()
    {
        // Create a dictionary that holds keys with values of the type OperationDelegate
        Dictionary<string, OperationDelegate> operations = new Dictionary<string, OperationDelegate>
        {
            { "Test", TornadoSirenTest },
            { "Real deal", RealTornado },
        };

        Console.WriteLine("Enter the operation (Test, Real deal):");
        string userInput = Console.ReadLine();

        if (operations.ContainsKey(userInput))
        {
            // Using the key to inject the corosponding method
            operations[userInput]();
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
    }
    // Method that can be used in the delegate
    static void TornadoSirenTest()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("waahhhhhhhhhh");
        }
    }
    // Method that can be used in the delegate
    static void RealTornado()
    {
        for (int i = 0; i < 20000; i++)
        {
            Console.WriteLine("waahhhhhhhhhh");
        }
    }
}
