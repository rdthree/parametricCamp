using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14b_StringInterpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            //two variables and their addition
            int a = 10;
            int b = 5;
            int sum = a + b;
            string message = $"{a} + {b} = {sum} and {a} x {b} = {a * b}";

            //composite formatting
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);

            //string interpolation
            Console.WriteLine($"{a} + {b} = {sum}");

            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
