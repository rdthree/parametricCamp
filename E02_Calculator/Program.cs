using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 2 numbers
            Console.Write("enter first variable: ");
            string valstr1 = Console.ReadLine();
            Console.Write("enter second variable: ");
            string valstr2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("--- calculations ---");


            //convert to numbers
            double val1 = 0;
            double val2 = 0;
            try
            {
            val1 = Convert.ToDouble(valstr1);
            val2 = Convert.ToDouble(valstr2);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("error. only type numbers");
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
                return;
            }

            //display computations
            double add = val1 + val2;
            double mult = val1 * val2;
            double sqrt = Math.Sqrt(val1 + val2);
            double sub = val1 - val2;
            double mod = val1 % val2;
            Console.WriteLine($"here are your variables added up: {add}");
            Console.WriteLine($"here they are multiplied: {mult}");
            Console.WriteLine($"how about their sum and then the square root of that sum: {sqrt}");
            Console.WriteLine($"let's subtract them: {sub}");
            Console.WriteLine($"a modulus you say? ok: {mod}");

            //stop the program
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
