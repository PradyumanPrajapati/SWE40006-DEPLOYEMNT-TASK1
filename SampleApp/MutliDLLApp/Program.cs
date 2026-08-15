using System;
using MathLibrary;
using GreetingLibrary;

namespace MultiDllApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            Greeting greeting = new Greeting();

            Console.WriteLine(greeting.GetGreeting("Pradyuman"));

            int sum = math.Add(5, 3);
            int product = math.Multiply(5, 3);

            Console.WriteLine("5 + 3 = " + sum);
            Console.WriteLine("5 * 3 = " + product);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}