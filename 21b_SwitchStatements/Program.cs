using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int posX = 0;
            int posY = 0;

            // wasd controls
            //char letterInput = 'w';
            //if (letterInput == 'd') { posX += 1; }
            //else if (letterInput == 'a') { posX -= 1; }
            //else if (letterInput == 'w') { posY += 1; }
            //else if (letterInput == 's') { posY -= 1; }

            bool keepReadingKey = true;
            while (keepReadingKey)
            {
                Console.Write("Enter a key: ");
                ConsoleKeyInfo input = Console.ReadKey();
                char letterInput = input.KeyChar;
                Console.WriteLine();

                switch(letterInput)
                {
                    case 'D':
                    case 'd': posX += 1; break;
                    case 'A':
                    case 'a': posX -= 1; break;
                    case 'W':
                    case 'w': posY += 1; break;
                    case 'S':
                    case 's': posY -= 1; break;
                    case 'Q':
                    case 'q': Console.WriteLine("Press any key to exit program..."); keepReadingKey = false; break;
                    default: Console.WriteLine($"key:'{letterInput}' has no function"); break;
                }
                Console.WriteLine($"Current position is ({posX}, {posY})");
            }


            Console.ReadKey();
        }
    }
}
