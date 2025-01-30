using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoesBudgetHouse
{
    class MenuItem
    {
        public static Random Randomizer = new Random();
        public string[] Proteins = { "Rost beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow musterd", "brown musterd", "honey musterd", "mayo", "relish", "french fressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };
        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiments + "on " + randomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01m);
            Price = price.ToString("c");
        }
    }
}
