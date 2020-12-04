using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //a list of numbers
            List<int> numbers = new List<int>();

            //add elements
            numbers.Add(0);

            for (int i = 0; i < 100; i+= 10)
            {
                numbers.Add(i);
            }

            Console.WriteLine(numbers[3]);

            numbers[3] = 9;
            Console.WriteLine(numbers[3]);

            Console.WriteLine();
            Console.WriteLine("the numbers array");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
