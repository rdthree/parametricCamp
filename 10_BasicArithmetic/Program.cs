using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_BasicArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare two integer variables
            int a = 7;
            int b = 3;

            int sum = a + b;
            int sub = a - b;
            int mult = a * b;
            int div = a / b; //beware of integer division
            Console.WriteLine(sum + " " + sub + " " + mult + " " + div);

            double realDivbroken = a / b; //this will still be an int, becuase a and b are ints
            double realDiv = (double)a / b;
            Console.WriteLine(realDiv);


            Console.ReadKey();
        }
    }
}
