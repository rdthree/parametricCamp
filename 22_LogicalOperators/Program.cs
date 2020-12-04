using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //two bools
            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(!a);      //NOT operator
            Console.WriteLine(a && b);  //AND operator
            Console.WriteLine(a || b);  //OR operator

            //vals to compare
            int value = 2;
            int min = 0;
            int max = 5;

            //where does val fall...
            if (value > max || value < min)
            {
                Console.WriteLine($"{value} is outside the range of [{min} to {max}]");
            }
            else if (value <= max && value >= min)
            {
                Console.WriteLine($"{value} is within the range of [{min} to {max}]");
            }

            Console.ReadKey();
        }
    }
}
