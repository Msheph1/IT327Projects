using System;

public delegate void OperationDelegate();

class Program
{
    static void Main()
    {
        Dictionary<string, OperationDelegate> operations = new Dictionary<string, OperationDelegate>
        {
            { "Test", TornadoSirenTest },
            { "Real deal", RealTornado },
        };

        Console.WriteLine("Enter the operation (Test, Real deal):");
        string userInput = Console.ReadLine();

        if (operations.ContainsKey(userInput))
        {
            operations[userInput]();
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
    }

    static void TornadoSirenTest()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("waahhhhhhhhhh");
        }
    }

    static void RealTornado()
    {
        for (int i = 0; i < 20000; i++)
        {
            Console.WriteLine("waahhhhhhhhhh");
        }
    }
}
