﻿using System.ComponentModel.Design;

namespace Hi_Lo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to HiLo.");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();
            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else return;
            }
            Console.WriteLine("the pot is empty. Bye!");
        }
    }
}
