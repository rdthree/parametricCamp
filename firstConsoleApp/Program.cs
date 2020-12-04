using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("whats ur name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"hey {name} whats up?");

            Console.Write($"{name} type a value: ");
            string valuetext = Console.ReadLine();
            double value = Convert.ToDouble(valuetext);
            Console.WriteLine($"{name}, this is your number times two: {value * 2}");
            Console.ReadKey();
        }
    }
}
