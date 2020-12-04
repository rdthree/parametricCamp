using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_VariableState
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2 variables
            int a = 2;
            int b = 3;

            int c = a + b;
            Console.WriteLine(c);

            b = 10;
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
