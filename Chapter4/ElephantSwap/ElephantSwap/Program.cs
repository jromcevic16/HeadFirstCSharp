using System.Globalization;

namespace ElephantSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucianda = new Elephant() { EarSize = 33, Name = "Lucianda" };
            Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucianda, 3 to swap");
            while (true)
            {
                char value = Console.ReadKey().KeyChar;
                Console.WriteLine("You pressed "+value);
                if (value == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (value == '2')
                {
                    Console.WriteLine("Calling lucianda.WhoAmI()");
                    lucianda.WhoAmI();
                }
                else if (value == '3')
                {
                    Elephant pivot = lucianda;
                    lucianda = lloyd;
                    lloyd = pivot;
                    Console.WriteLine("References have been swapped");
                }
                else if(value == '4')
                {
                    lloyd = lucianda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if(value == '5')
                {
                    lucianda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
