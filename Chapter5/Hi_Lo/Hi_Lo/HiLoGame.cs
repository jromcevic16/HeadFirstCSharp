using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Lo
{
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(MAXIMUM)+1;
        private static int pot = 10;

        public static void Guess(bool higher)
        {
            int newRandomNumber = random.Next(MAXIMUM) + 1;
            if (higher && newRandomNumber >= currentNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else if(!higher && newRandomNumber <= currentNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = newRandomNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is at least {half}");
            else
                Console.WriteLine($"The number is at most {half}");
            pot--;
        }

        public static int GetPot()
        {
            return pot;
        }
    }
}
