using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //two vals
            int a = 10;
            int b = 5;

            //save as bool var
            bool isGreater = a > b;
            Console.WriteLine($"is {a} greater than {b}? {a > b}");
            Console.WriteLine($"does {a} = {b}? {a == b}");

            Console.ReadKey();
        }
    }
}
