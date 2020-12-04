using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversions between data types
            int a = 10;

            //implicit conversion
            double num = 15; //ok even though integer
            string letter = "a"; //ok even though a char, but needs ""

            //casting
            int b = (int)23.455;
            int d = (int)23.9999999; //this isn't a rounding function, just trims decimals
            Console.WriteLine(b + ", " + d);

            //explicit conversion

            int f = Convert.ToInt32(true);
            Console.WriteLine(f);

            double numberFromString = Convert.ToDouble("234.23523");
            Console.WriteLine(numberFromString);

            //convert to strings
            string numberAsString = 123123423509814.ToString();
            Console.WriteLine(numberAsString);

            Console.ReadKey();
        }
    }
}
