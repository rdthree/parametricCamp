using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_SimpleFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 23;
            double sum = Addition(a, b);
            Console.WriteLine(sum);

            //string msg = Greet("ray");
            //Console.WriteLine(msg);
            Console.WriteLine(Greet("ray ray"));

            Console.ReadKey();
        }
        /// <summary>
        /// Greets a person/place/thing by name
        /// </summary>
        /// <param name="name">The name of the person/place/thing</param>
        /// <returns></returns>
        static string Greet(string name)
        {
            //string msg = $"hello {name}!";
            //return msg;
            return $"hello {name}!";
        }
        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="valueA">The first value</param>
        /// <param name="valueB">The second value</param>
        /// <returns></returns>
        static double Addition(double valueA, double valueB)
        {
            //double added = valueA + valueB;
            //return added;
            return valueA + valueB;
        }
    }
}
