using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
            {
                numbers[i] = 5 * i;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
