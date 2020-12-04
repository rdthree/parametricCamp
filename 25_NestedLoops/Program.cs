using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrix
            int maxRows = 7;
            int maxColumns = 20;

            for (int j = 0; j < maxRows; j++)
            {
                for (int i = 0; i < maxColumns; i++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
