using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_NumbericalSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //examples
            Console.WriteLine("first ten digits");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("first ten negative digits");
            for (int i = 0; i > -10; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("first ten squares");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine();

            Console.WriteLine("first ten even numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * 2);
            }
            Console.WriteLine();

            Console.WriteLine("first ten even numbers");
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                Console.WriteLine(i * 2);
                counter++;
                    if (counter > 9)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("first ten odd numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(2 * i + 1);
            }
            Console.WriteLine();

            long multiplicate = 1921235235235;
            Console.WriteLine($"multiplication table for {multiplicate}");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{multiplicate} x {i} = {multiplicate * i}");
            }
            Console.WriteLine();

            Console.WriteLine($"a geometric series");
            for (double i = 1; i < 100; i *= 1.5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine($"an asymptotic geometric series");
            for (double i = 1; i > 0.0001; i *= 0.5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////////////////

            //use ASCII codes
            Console.WriteLine("the alphabet");
            string alphabet = "";
            for (int i = 0; i < 26; i++) {
                alphabet += (char) (65 + i);
                Console.WriteLine($"{i+1}: {(char) (65 + i)}: {alphabet}");
            }
            Console.WriteLine();

            Console.WriteLine("addition of the first ten numbers");
            int massAddition = 0;
            for (int i=0; i < 10; i++)
            {
                massAddition += i;
            }
            Console.WriteLine(massAddition);
            Console.WriteLine();

            Console.WriteLine("fibonachas");
            int prev1 = 1;
            int prev2 = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            for (int i = 0; i < 10; i++)
            {
                int sum = prev1 + prev2;
                Console.WriteLine(sum);

                prev1 = prev2;
                prev2 = sum;
            }

            /////////////////////////////////

            //prime numbas
            Console.WriteLine("primes");
            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true; //this the "flag" we are using (assume all primes to start)
                for (int j = 2; j < i; j++) //divide each number by the numbers below it down to 2
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
