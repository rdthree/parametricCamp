using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_ASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASCII ART
            Console.WriteLine("create some ASCII art");
            Console.WriteLine();

            Console.Write("input rectangle width: ");
            string widthString = Console.ReadLine();
            Console.WriteLine();

            Console.Write("input rectangle height: ");
            string heightString = Console.ReadLine();
            Console.WriteLine();

            int width = Convert.ToInt32(widthString);
            int height = Convert.ToInt32(heightString);

            Console.WriteLine("SOLID RECTANGLE");
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("BORDER RECTANGLE");
            int borderW = 2;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j < borderW || i < borderW || j >= height - borderW || i >= width - borderW)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("CHECKER PATTERN");
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("▓");
                    }
                    else
                    {
                        Console.Write("░");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("PYRAMID PATTERN");
            int pyrWidth = 2 * height - 1;
            int centerCol = pyrWidth / 2;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < pyrWidth; i++)
                {
                    //first half of the pyramid starts at the center and adds
                    //a 'pixel' per extra row, making the right slope of the pyramid
                    //
                    //followup: try making a diamond, try making slashes to show edges
                    if (i >= centerCol - j && i <= centerCol + j)
                    {
                        Console.Write("▓");
                    }
                    else
                    {
                        Console.Write("░");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("CIRCLE");
            double centerX = (width - 1) / 2.0;
            double centerY = (height - 1) / 2.0;
            double radius = 0;
            //center the radius in a rectangle
            if (height < width)
            {
                radius = 0.5 * height;
            }
            else
            {
                radius = 0.5 * width;
            }
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    //if distance from i or j is less than the radius
                    //then its inside the circle, turn it on
                    double dx = i - centerX;
                    double dy = j - centerY;
                    //pythagorean distance of center to x, center to y:
                    //square root of (distance x^2) * (distance y^2)
                    double d = Math.Sqrt(dx * dx + dy * dy);

                    if (d < radius)
                    {
                        Console.Write("▓");
                    }
                    else
                    {
                        Console.Write("░");
                    }
                }
                Console.WriteLine();
            } 





            Console.ReadKey();
        }
    }
}
