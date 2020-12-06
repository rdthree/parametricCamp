using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyGeometryKernel;

namespace ConsoleApp_MyGeometryKernel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test app");

            Vector v0 = new Vector(0, 1, 2);
            Point p = new Point(1, 1, 1);
            Line l = new Line(p, v0);

            Console.WriteLine($"Vector v0 is: [{v0}], Point p is: [{p}], Line l is: [{l}]");

            Console.ReadKey();
        }
    }
}
