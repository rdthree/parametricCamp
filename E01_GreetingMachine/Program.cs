using System;

namespace E01_GreetingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //user name
            Console.WriteLine("whats ur name");
            string name = Console.ReadLine();

            //greeting
            Console.WriteLine($"hello {name}, whats up");

            //stop the program
            Console.ReadKey();
        }
    }
}
