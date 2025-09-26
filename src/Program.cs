using System;

namespace TestWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, .NET 9 World!");
            Console.WriteLine($"Current time: {DateTime.Now}");
            
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments provided:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"  [{i}]: {args[i]}");
                }
            }
            else
            {
                Console.WriteLine("No arguments provided.");
            }
            
            Console.WriteLine("Application completed successfully!");
        }
    }
}