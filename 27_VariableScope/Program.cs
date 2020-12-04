using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 50;
            string message;

            if (a > b)
            {
                message = "greater";
            }
            else
            {
                message = "not greater";
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
