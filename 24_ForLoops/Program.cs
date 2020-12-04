using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //print first ten digits
            int r = 0;

            for (double i = 1; i < 1000; i*=1.5)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
