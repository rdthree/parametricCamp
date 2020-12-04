using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_NamingConventions
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables in CamelCase
            string myName = "ray";

            //lengths
            double t = 25.5;                //too short
            double temp = 25.5;             //confusing temporary/temperature?
            double temperature = 25.5;      //better but long
            double roomTemp = 25.5;         //pretty good
            double roomTemperature = 25.5;  //too long

            //functions and classes in PascalCase
            Console.WriteLine("Writeline is in PascalCase");

        }
    }
}
