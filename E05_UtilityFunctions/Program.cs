using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_UtilityFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Let's create some utility functions");

            double a = 5;
            double b = 7;
            double sum = Addition(a, b);
            PrintLine(sum);

            double mult = Mult(a, b);
            PrintLine(mult);

            double radius = 1;
            PrintLine($"Circle Length = {CircleLength(radius)} units");
            PrintLine($"Circle Area = {CircleArea(radius)} units squared");

            double exponi = 9;
            double exponinin = Pow(a, exponi);
            PrintLine($"Double A ({a}) to the power of ({exponi}) is {exponinin}");

            PrintLine($"is {a} greater than {b}? {IsGreater(a, b)}");

            double dist = DistBtwnPts(0, 0, 4, 3);
            PrintLine($"distance between points is: {dist}");

            bool insideCircle = IsInCirc(1, 1, 7, 1, 5);
            PrintLine($"Is inside circle? {insideCircle}");

            double[] numbs = { 2, 4, 6, 8, 10 };
            PrintLine("mass addition time: " + Addition(numbs));
            Print(numbs);
            PrintLine($"the average is: {Avg(numbs)}");

            double[] nooms = NumSeries(0, 2, 5);
            PrintLine($"this is a numerical seried my dudes: {nooms} ");
            Print(nooms);

            Console.ReadKey();
        }

        static void PrintLine(string message) => Console.WriteLine(message);
        static void PrintLine(double message) => Console.WriteLine(message);
        static void Print(string message) => Console.Write(message);
        static void Print(double message) => Console.Write(message);
        static void PrintLine(double[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                Console.WriteLine(vals[i]);
            }
        }
        static void Print(double[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                Console.Write($"{vals[i]} ");
            }
            Console.WriteLine();
        }

        static double Addition(double a, double b) => a + b;
        static double Addition(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        } 
        static double Mult(double a, double b) => a * b;
        static double CircleLength(double radius) => 2 * Math.PI * radius;
        static double CircleArea(double radius) => Math.PI * radius * radius;

        static double Pow(double @base, double exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            double val = @base;
            for (int i = 0; i < exponent - 1; i++)
            {
                val *= @base;
            }
            return val;
        }

        static bool IsGreater(double a, double b) => a > b;

        static double DistBtwnPts(double x0, double y0, double x1, double y1)
        {
            double dx = x1 - x0;
            double dy = y1 - y0;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static double DistBtwnPts(double x0, double y0, double x1, double y1, double r)
        {
            double dx = x1 - x0;
            double dy = y1 - y0;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static bool IsInCirc(double cx, double cy, double x, double y, double r)
        {
            double dist = DistBtwnPts(cx, cy, x, y, r);
            bool isInside = dist < r;
            return isInside;
        }

        static double Avg(double[] val)
        {
            double total = Addition(val);
            double avg = total / val.Length;
            return avg;
        }

        static double[] NumSeries(double start, double step, int count)
        {
            double[] list = new double[count];
            for (int i = 0; i < count; i++)
            {
                list[i] = start + i * step;
            }
            return list;
        }

        static double[] NumRange(double start, double end, int steps)
        {
            double step = (end - start) / steps;
            return NumSeries(start, step, steps + 1);
        }
    }
}
