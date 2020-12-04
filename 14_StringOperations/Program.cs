using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //string variables
            string greet = "sup";
            string name = "dog";

            //concatenate strings with +
            string message = greet + " " + name + "!";
            Console.WriteLine(message + " yeah dawg");

            Console.ReadKey();
        }
    }
}
