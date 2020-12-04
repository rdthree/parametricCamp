using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_LoopsBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int threshold = 500;
            //square numbers
            int firstSquare = 0;
            int firstValue = 0;
            for (int i = 0; i < 50; i ++)
            {
                if (i * i >= threshold)
                {
                    Console.WriteLine(i * i);
                    firstValue = i;
                    firstSquare = i * i;
                    break;
                }
            }

            Console.WriteLine($"the first square number is {firstSquare}, the first square value is {firstValue}");
            Console.ReadKey();
        }
    }
}
