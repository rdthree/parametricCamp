using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_VoidFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet("ray ray");
            Log("MUUAAHAHAHAAH");

            Console.ReadKey();
        }

        static void Log(string str)
        {
            Console.WriteLine(str);
        }

        static void Greet(string name)
        {
            Console.WriteLine($"hello {name}");
        }
    }
}
