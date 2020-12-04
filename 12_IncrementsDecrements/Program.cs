using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IncrementsDecrements
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int a = 5;
            Console.WriteLine("a = " + a);

            //increase by one because the assigment work like this
            //right side is executed FIRST
            //value of the right side is stored in the left side SECOND
            a = a + 1;
            Console.WriteLine("a + 1 = " + a);

            a += 4;
            Console.WriteLine("a + 4 = " + a);
            a -= 3;
            Console.WriteLine("a - 3 = " + a);
            a *= 2;
            Console.WriteLine("a x 2 = " + a);
            a /= 3;
            Console.WriteLine("a / 3 = " + a);
            a++;
            Console.WriteLine("a++ = " + a);
            a--;
            Console.WriteLine("a-- = " + a);

            Console.ReadKey();
        }
    }
}
